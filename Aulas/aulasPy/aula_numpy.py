import numpy as np

nomes = []
notas = []
i = 1

def inserirAluno():
    global i
    for i in range(i, 21):  
        nome = input(f"Introduza o nome do {i} aluno: ")
        nomes.append(nome)

        nota = float(input(f"Introduza a nota do {i} aluno: ")) 
        notas.append(nota)

        stop = input("Pressione Enter para continuar ou introduza 'stop' para voltar ao menu\n")
        if stop.lower() == "stop":
            i += 1  # Increment the student count
            break
        
def getMedia():
    if notas:
        return np.mean(notas)
    else:
        return 0

def getNotaMax():
    if notas:
        return max(notas)
    else:
        return 0

def getNotaMin():
    if notas:
        return min(notas)
    else:
        return 0

def main():
    while True:
        print("\n1 Inserir alunos")
        print("2 Ver alunos")
        print("3 Ver média de alunos")
        print("4 Ver nota mais alta e mais baixa")
        print("5 Sair")
        
        opcao = input("Escolha uma opção: ")

        
        if opcao == '1':
            inserirAluno()
        elif opcao == '2':
            for i in range(len(nomes)):
                if notas[i] > 9.5:
                    print(f"Nome: {nomes[i]}, Nota: {notas[i]}, Aprovado")
                else:
                    print(f"Nome: {nomes[i]}, Nota: {notas[i]}, Reprovado")                    
        elif opcao == '3':
            media = getMedia()
            print(f"Média das notas: {media}")
        elif opcao == '4':
            notaMax = getNotaMax()
            notaMin = getNotaMin()
            print(f"Nota mais alta: {notaMax}\nNota mais baixa: {notaMin}")
        elif opcao == '5':
            break
        else:
            print("Opção inválida. Tente novamente.")

if __name__ == "__main__":
    main()