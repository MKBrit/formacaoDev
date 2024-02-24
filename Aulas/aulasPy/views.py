# views.py
# define o interface para o utilizador

import tkinter as tk
from controllers import FormularioController

class FormularioView:
    def __init__(self,master):
        self.controller = FormularioController()

        self.entrada = tk.Entry(master)
        self.entrada.pack()

        self.button_adicionar = tk.Button(master, text="Adicionar", command=self.criar)
        self.button_adicionar.pack()

        self.lista = tk.Listbox(master)
        self.lista.pack()

    def criar(self):
        valor = self.entrada.get()
        self.controller.adicionar(valor)
        self.mostrar_dados()

    def mostrar_dados(self):
        self.lista.delete(0, tk.END)
        for item in self.controller.ler():
            self.lista.insert(tk.END, item)
