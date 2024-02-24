import pygame as pyg
from pygame import *

# Initialize pygame
pyg.init()

### Game properties ###

# Run flag
run = True

# Define some colors
BLACK = (0,0,0)
WHITE = (255,255,255)
RED = (255, 0, 0)

# Define window size
W, H = 800, 600
SCREEN = pyg.display.set_mode((W, H))

# Define window name
pyg.display.set_caption('bimbimbambam')

# Load player image
player = pyg.image.load('icon.ico')
# defining speed threshold
speed = 50

# defining player position
x = ((W - player.get_width()) // 2)
y = ((H - player.get_height()) // 2)


### Main Loop ###

while run:
    # Get input from user
    for event in pyg.event.get():
        if event.type == pyg.QUIT:
            run = False

        # Fill game screen w/ a color
        SCREEN.fill(WHITE)
        SCREEN.blit(player, (x, y))

        # Defining keys
        keys = pyg.key.get_pressed()
        if keys[K_LEFT] or keys[K_a]:
            x -= speed
        if keys[K_RIGHT] or keys[K_d]:
            x += speed
        if keys[K_UP] or keys[K_w]:
            y -= speed
        if keys[K_DOWN] or keys[K_s]:
            y += speed

        # Update screen
        pyg.display.flip()

        # Set frames per sec
        pyg.time.Clock().tick(144)


# When quit is pressed, this leaves the game
pyg.quit()