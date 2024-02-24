from pong import Game
import tkinter as tk
from tkinter import ttk


game = Game()

menu = tk.Tk()
menu.geometry("500x300")

menu.title("Main Menu") 
menu.configure(background="white")

style = ttk.Style()
style.theme_use("clam")
style.configure('TLabel', font=("comic Sans MS", 18), background="white")
style.configure('TButton', font=("Comic Sans MS", 12), relief="groove")

welcomeLabel = ttk.Label(menu, text="Welcome to Ice Hockey Pong",style="TLabel")
welcomeLabel.pack(pady=40)

pushStart = ttk.Button(menu, text="New Game", style="TButton", command=game.main_loop)
pushStart.pack(pady=10)

pushExit = ttk.Button(menu, text="Exit", style="TButton", command=menu.destroy)
pushExit.pack(pady=10)

menu.mainloop()