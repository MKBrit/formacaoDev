# Importar a livraria Turtle
import turtle

class Game():
    def main_loop(self):
        # Criar ecrã
        sc = turtle.Screen()
        sc.title("ICE HOCKEY")
        sc.bgpic("board.png")
        sc.setup(width=1000, height=600)
        
        # Jogador 1
        left_pad = turtle.Turtle()
        left_pad.speed(5)
        left_pad.shape("square")
        left_pad.color("red")
        left_pad.resizemode("auto")
        left_pad.shapesize(stretch_wid=6, stretch_len=1)
        left_pad.penup()
        left_pad.goto(-400, 0)
        
        # Jogador 2
        right_pad = turtle.Turtle()
        right_pad.speed(5)
        right_pad.shape("square")
        right_pad.color("blue")
        right_pad.resizemode("auto")
        right_pad.shapesize(stretch_wid=6, stretch_len=1)
        right_pad.penup()
        right_pad.goto(400, 0)
        
        # Bola
        hit_ball = turtle.Turtle()
        hit_ball.speed(400)
        hit_ball.shape("circle")
        hit_ball.color("black")
        hit_ball.penup()
        hit_ball.goto(0, 0)
        hit_ball.dx = 5
        hit_ball.dy = -5
        
        # Inicializador das variáveis de score
        left_player = 0
        right_player = 0
        
        # Mostrar Score
        sketch = turtle.Turtle()
        sketch.speed(0)
        sketch.color("blue")
        sketch.penup()
        sketch.hideturtle()
        sketch.goto(0, 260)
        sketch.write("Davide : 0 Miguel: 0", align="center", font=("Comic Sans MS", 24, "normal"))
        
        # Funções para mover o Pad do jogador na vertical
        # Pad esquerdo
        def paddleaup():
            y = left_pad.ycor()
            y += 20
            left_pad.sety(y)
        
        def paddleadown():
            y = left_pad.ycor()
            y -= 20
            left_pad.sety(y)
        
        # Pad direito
        def paddlebup():
            y = right_pad.ycor()
            y += 20
            right_pad.sety(y)
        
        def paddlebdown():
            y = right_pad.ycor()
            y -= 20
            right_pad.sety(y)
        
        # Função para verificar a colisão com o pad
        def check_collision_with_pad():
            return (
                hit_ball.xcor() > left_pad.xcor() - 20 and
                hit_ball.xcor() < left_pad.xcor() + 20 and
                hit_ball.ycor() < left_pad.ycor() + 60 and
                hit_ball.ycor() > left_pad.ycor() - 60
            )
        
        # Controlos
        sc.listen()
        
        # Jogador da esquerda
        sc.onkeypress(paddleaup, "w")
        sc.onkeypress(paddleadown, "s")
        
        # Jogador da direita
        sc.onkeypress(paddlebup, "Up")
        sc.onkeypress(paddlebdown, "Down")
        
        while True:
            sc.update()
        
            hit_ball.setx(hit_ball.xcor() + hit_ball.dx)
            hit_ball.sety(hit_ball.ycor() + hit_ball.dy)
        
            # Verificar colisão com o pad
            if check_collision_with_pad():
                hit_ball.setx(left_pad.xcor() + 20)
                hit_ball.dx *= -1
        
            # Verificar os limites de jogo
            if hit_ball.ycor() > 280:
                hit_ball.sety(280)
                hit_ball.dy *= -1
        
            if hit_ball.ycor() < -280:
                hit_ball.sety(-280)
                hit_ball.dy *= -1
        
            if hit_ball.xcor() > 500:
                hit_ball.goto(0, 0)
                hit_ball.dy *= -1
                left_player += 1
                sketch.clear()
                sketch.write("Davide : {} Miguel : {}".format(left_player, right_player), align="center", font=("Comic Sans MS", 24, "normal"))
        
            if hit_ball.xcor() < -500:
                hit_ball.goto(0, 0)
                hit_ball.dy *= -1
                right_player += 1
                sketch.clear()
                sketch.write("Davide : {} Miguel : {}".format(left_player, right_player), align="center", font=("Comic Sans MS", 24, "normal"))
        
            # Collider da bola com os Pads
            # Pad esquerdo
            if (hit_ball.xcor() > 360 and hit_ball.xcor() < 370) and (hit_ball.ycor() < right_pad.ycor()+100 and hit_ball.ycor() > right_pad.ycor()-100):
                hit_ball.setx(360)
                hit_ball.dx *= -1
        
            # Pad direito
            if (hit_ball.xcor() < -360 and hit_ball.xcor() > -370) and (hit_ball.ycor() < left_pad.ycor()+100 and hit_ball.ycor() > left_pad.ycor()-100):
                hit_ball.setx(-360)
                hit_ball.dx *= -1
        