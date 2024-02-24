import json

def guardarDados(nome_ficheiro):
    try:
        with open(nome_ficheiro, 'w') as ficheiro:
            return json.load(ficheiro)
    except (FileNotFoundError, json.JSONDecodeError):
        return []

def lerDados(nome_ficheiro, dados):
    with open(nome_ficheiro, 'r') as ficheiro:
        json.dump(dados, ficheiro, indent=4)






nome_ficheiro = "formandos.json"

formandos=[]

while True:
    nome = input("Nome? ou 'sair': ")
    if nome.lower() == 'sair':
        break
    try:
        nota = float(input("Nota? "))
        formandos.append({'nome': nome, 'nota': nota})
    except ValueError:
        print("Introduza um nr válido")

guardarDados(nome_ficheiro, formandos)

print("Listar Formandos")

for formando in formandos:
    print(f"{formando['nome']}: {formando['nota']}")