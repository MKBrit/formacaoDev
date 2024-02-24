

class FormularioController:

    def __init__(self):
        self.dados = []

    def adicionar(self, valor):
        self.dados.append(valor)
        return valor
    
    def ler(self):
        return self.dados
    