import pygame as pyg
from pygame import *

# Initialize pygame
pyg.init()

# Game properties

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

# Define game font
fonte = pyg.font.SysFont(None, 55)

# defining player position
player = pyg.Rect(300, 220, 20, 20)
# defining speed threshold
speed = 50


### Main Loop ###

while run:
    # Get input from user
    for event in pyg.event.get():
        if event.type == pyg.QUIT:
            run = False

        # Fill game screen w/ a color
        SCREEN.fill(BLACK)

        # Draw player with updated position
        pyg.draw.rect(SCREEN, RED, player)

        # Defining keys
        keys = pyg.key.get_pressed()
        if keys[K_LEFT] or keys[K_a]:
            player.x -= speed
        if keys[K_RIGHT] or keys[K_d]:
            player.x += speed
        if keys[K_UP] or keys[K_w]:
            player.y -= speed
        if keys[K_DOWN] or keys[K_s]:
            player.y += speed

        # Update screen
        pyg.display.flip()

        # Set frames per sec
        pyg.time.Clock().tick(144)


# When quit is pressed, this leaves the game
pyg.quit()