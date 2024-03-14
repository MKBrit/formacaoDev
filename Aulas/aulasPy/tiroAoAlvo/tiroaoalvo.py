import pygame
import random
import math

# Inicializar pygame
pygame.init()

pygame.mixer.init()
background_music = pygame.mixer.Sound('song.mp3')

# Cores
WHITE = (255, 255, 255)
GREEN = (0, 255, 0)
BLUE = (0, 0, 255)
BROWN = (139, 69, 19)
BLACK = (0, 0, 0)
RED = (255, 0, 0)
YELLOW = (255, 255, 0)
MAGENTA = (255, 0, 255)
ORANGE = (255, 165, 0)
BROWN = (139, 69, 19)  # cor castanha
GREEN_BACKGROUND = (135, 206, 235)
TREE_TRUNK = (139, 69, 19)
TREE_LEAVES = ORANGE
FRUIT_COLOR = (255, 0, 0)
FLOWER_PETAL = (255, 255, 0)
FLOWER_CENTER = (255, 223, 186)

# Configurações da tela
WIDTH, HEIGHT = 800, 600
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Tiro ao Alvo com Arco")

BOW_CENTER_X = WIDTH // 2
BOW_CENTER_Y = int(HEIGHT * 0.9)
ARROW_LENGTH = 60
ARROW_X = BOW_CENTER_X
ARROW_Y = BOW_CENTER_Y - ARROW_LENGTH // 2
ARROW_SPEED = 10
arrow_hit_target = False
arrow_in_motion = False

TARGET_RADIUS = 25
new_radius = TARGET_RADIUS
moving_target_x = 0
moving_target_y = random.randint(new_radius, HEIGHT // 2 - new_radius)
moving_target_speed = 5
score = 0
radius_reduction = 0
TARGET_CENTER_RADIUS = TARGET_RADIUS // 4

y_diff_when_hit = 0

font = pygame.font.SysFont(None, 36)

def draw_realistic_lake(surface, color):
    lake_points = [
        (WIDTH - 100, HEIGHT // 2 - 50),
        (WIDTH - 80, HEIGHT // 2 - 45),
        (WIDTH - 60, HEIGHT // 2 - 40),
        (WIDTH - 50, HEIGHT // 2 - 30),
        (WIDTH - 40, HEIGHT // 2 - 20),
        (WIDTH - 30, HEIGHT // 2 - 15),
        (WIDTH - 20, HEIGHT // 2),
        (WIDTH - 10, HEIGHT // 2 + 10),
        (WIDTH - 20, HEIGHT // 2 + 20),
        (WIDTH - 40, HEIGHT // 2 + 40),
        (WIDTH - 60, HEIGHT // 2 + 50),
        (WIDTH - 80, HEIGHT // 2 + 50),
        (WIDTH - 100, HEIGHT // 2 + 40)
    ]
    pygame.draw.polygon(surface, color, lake_points)

def draw_tree(surface, x, y):
    # Desenha a folhagem da árvore
    pygame.draw.circle(surface, TREE_LEAVES, (x + 10, y - 10), 40)
    
def draw_fruit(surface, tree_x, tree_y):
    # As coordenadas são relativas à posição da árvore para posicionar as frutas
    fruit_positions = [
        (tree_x + 5, tree_y - 15),
        (tree_x + 20, tree_y - 20),
        (tree_x - 5, tree_y - 30),
        (tree_x + 15, tree_y - 40)
    ]
    for fruit in fruit_positions:
        pygame.draw.circle(surface, FRUIT_COLOR, fruit, 5)

# Definindo posições fixas para as árvores
tree_positions = [
    (100, HEIGHT // 2 - 50),
    (150, HEIGHT // 2 + 80),
    (130, HEIGHT // 2 - 200),
    (700, HEIGHT // 2 - 100),
    (500, HEIGHT // 2 + 60),
    (590, HEIGHT // 2 - 200)
]

def draw_flower(surface, x, y):
    """Desenha uma flor com centro em (x, y)"""

    # Desenha pétalas da flor
    petal_positions = [
        (x, y - 10), (x, y + 10),
        (x - 10, y), (x + 10, y),
        (x + 7, y - 7), (x - 7, y + 7),
        (x + 7, y + 7), (x - 7, y - 7)
    ]
    for petal in petal_positions:
        pygame.draw.circle(surface, FLOWER_PETAL, petal, 5)
# Definindo posições fixas para as flores
flower_positions = [
    (50, 80), (80, 150),
    (60, 200), (250, 505),
    (300, 495), (350, 500),
    (600, 200), (450, 490),
    (500, 505), (550, 495)
]

# Configurações da ave
bird_x = 0  # posição inicial x da ave
bird_y = random.randint(50, HEIGHT - 50)  # posição inicial y da ave
bird_speed_x = 3
bird_speed_y = random.randint(-2, 2)  # velocidade vertical aleatória para dar mais realismo
bird_direction = 1  # 1 para subir, -1 para descer
BIRD_COLOR = (255, 255, 255)  # branco

def draw_bird(surface, x, y, direction):
    pygame.draw.circle(surface, BIRD_COLOR, (x, y), 10)  # cabeça
    pygame.draw.line(surface, BIRD_COLOR, (x, y), (x + 20, y), 3)  # corpo
    pygame.draw.circle(surface, BIRD_COLOR, (x + 10, y - 10 * direction), 7)  # asa superior
    pygame.draw.circle(surface, BIRD_COLOR, (x + 10, y + 10 * direction), 7)  # asa inferior

def draw_target(x, y, radius):
    w, h = 50, 50
    pic = pygame.image.load("Foto.png")
    pic = pygame.transform.scale(pic, (w, h))
    screen.blit(pic, (x - (radius/4), y - (radius/4)))

def draw_bow(surface, x, y):
    pygame.draw.line(surface, ORANGE, (x - 30, y), (x + 30, y), 3)
    pygame.draw.arc(surface, ORANGE, (x - 30, y - 30, 60, 60), 0, math.pi, 5)

def draw_arrow(surface, x, y):
    pygame.draw.line(surface, GREEN, (x, y - ARROW_LENGTH // 2), (x, y + ARROW_LENGTH // 2), 3)
    pygame.draw.polygon(surface, GREEN, [(x, y - ARROW_LENGTH // 2), (x - 5, y - ARROW_LENGTH // 2 + 10), (x + 5, y - ARROW_LENGTH // 2 + 10)])
    pygame.draw.polygon(surface, BROWN,  [(x, y), (x - 5, y + ARROW_LENGTH // 2), (x + 5, y + ARROW_LENGTH // 2)])

def draw_swing(surface, x, y):
    # Definindo algumas dimensões
    post_height = 100
    post_width = 5
    seat_width = 40
    seat_height = 10
    rope_length = 60
    
    # Desenhar os suportes/estacas
    pygame.draw.rect(surface, BROWN, (x - seat_width//2 - post_width, y - post_height, post_width, post_height))
    pygame.draw.rect(surface, BROWN, (x + seat_width//2, y - post_height, post_width, post_height))
    
    # Desenhar as cordas
    pygame.draw.line(surface, BLACK, (x - seat_width//2, y - post_height), (x - seat_width//2, y - post_height + rope_length), 2)
    pygame.draw.line(surface, BLACK, (x + seat_width//2, y - post_height), (x + seat_width//2, y - post_height + rope_length), 2)
    
    # Desenhar o assento
    pygame.draw.rect(surface, RED, (x - seat_width//2, y - post_height + rope_length, seat_width, seat_height))

music_started = False

# Loop do jogo
running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
        if event.type == pygame.MOUSEBUTTONDOWN:
            mouse_x, mouse_y = pygame.mouse.get_pos()
            distance_to_bow = math.sqrt((mouse_x - BOW_CENTER_X)**2 + (mouse_y - BOW_CENTER_Y)**2)
            if distance_to_bow <= 30:
                arrow_in_motion = True

    if arrow_in_motion:
        ARROW_Y -= ARROW_SPEED
        distance_to_target = ((moving_target_x - ARROW_X)**2 + (moving_target_y - ARROW_Y)**2)**0.5
        if distance_to_target < (TARGET_RADIUS - radius_reduction) and not arrow_hit_target:
            arrow_hit_target = True
            y_diff_when_hit = ARROW_Y - moving_target_y
            if distance_to_target < (TARGET_CENTER_RADIUS - radius_reduction):
                score += 20
            else:
                score += 5
        elif arrow_hit_target:
            ARROW_Y = moving_target_y + y_diff_when_hit

        if ARROW_Y + ARROW_LENGTH < 0:
            arrow_in_motion = False
            arrow_hit_target = False
            ARROW_Y = BOW_CENTER_Y - ARROW_LENGTH // 2

    if arrow_hit_target:
        ARROW_X = moving_target_x

    if score >= 5 and not music_started:
        background_music.play(-1)
        music_started = True

    # Pintar fundo
    screen.fill(GREEN_BACKGROUND)
    
    # Desenhar lago
    draw_realistic_lake(screen, BLUE)

    # Desenhar árvores fixas com frutas
    for pos in tree_positions:
        draw_tree(screen, pos[0], pos[1])
        draw_fruit(screen, pos[0], pos[1])

        # Desenhar flores
    for pos in flower_positions:
        draw_flower(screen, pos[0], pos[1])

# Desenhar o baloiço
    draw_swing(screen, 650, 250)  # Isso posicionará o baloiço aproximadamente no meio do lado direito da tela

    moving_target_x += moving_target_speed
    if moving_target_x > WIDTH:
        moving_target_x = 0
        radius_reduction = score // 50
        new_radius = TARGET_RADIUS - radius_reduction
        moving_target_y = random.randint(new_radius, HEIGHT // 2 - new_radius)
        # Reset arrow
        ARROW_X = BOW_CENTER_X
        ARROW_Y = BOW_CENTER_Y - ARROW_LENGTH // 2
        arrow_in_motion = False
        arrow_hit_target = False

        # Atualizar a posição e direção da ave
    bird_x += bird_speed_x
    bird_y += bird_speed_y
    if bird_y < 50 or bird_y > HEIGHT - 50:  # altera a direção vertical quando atinge os limites
        bird_speed_y *= -1

    if bird_x > WIDTH:  # se a ave sair completamente da tela à direita, reinicie-a à esquerda
        bird_x = 0
        bird_y = random.randint(50, HEIGHT - 50)
        bird_speed_y = random.randint(-2, 2)

    # Alterar direção das asas
    if bird_y % 20 == 0:  # mudar a direção das asas a cada 20 pixels
        bird_direction *= -1

    # Desenhar a ave
    draw_bird(screen, bird_x, bird_y, bird_direction)

    draw_target(moving_target_x, moving_target_y, new_radius)
    draw_bow(screen, BOW_CENTER_X, BOW_CENTER_Y)
    draw_arrow(screen, ARROW_X, ARROW_Y)
    score_text = font.render(f"Score: {score}", True, BLACK)
    screen.blit(score_text, (10, 10))

    pygame.display.flip()
    pygame.time.Clock().tick(60)

pygame.quit()
