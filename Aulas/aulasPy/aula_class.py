class Formando:
    id = 0
    nome = ""
    apelido = ""
    ufcd = ""
    nota = 0

    def __init__(self, id, nome, apelido,ufcd, nota):
        self.id = id
        self.nome = nome
        self.apelido = apelido
        self.ufcd = ufcd
        self.nota = nota

    def __str__(self):
        if self.nota >= 9.5:
            return (f"O Formando {self.apelido}, com o id{self.id}, de {self.ufcd}, com uma avaliação de {self.nota}, foi Aprovado") 
        elif self.nota < 9.5:
            return (f"O Formando {self.apelido}, com o id{self.id}, de {self.ufcd}, com uma avaliação de {self.nota}, foi Reprovado") 
    


formando1 = Formando(1, "André", "Santos", "Analista de Sistemas", 9.6)
formando2 = Formando(2, "João", "Sousa", "Engenheiro Software", 9.5)
formando3 = Formando(3, "Rafael", "Silva", "Construção Civil", 9.4)

print(formando1) 
print(formando2)
print(formando3)