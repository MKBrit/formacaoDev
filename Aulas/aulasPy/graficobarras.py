# criar gráficos com a biblio matplotlib
# instalar se não estiver: pip install matplotlib
import matplotlib.pyplot as plt

# Dados
equipas = ['Benfica', 'Sporting','Porto','Braga']
pontos = [29, 29, 26, 20]

# grafico - x, y - x: horizontal e y: vertical

# cores
cores = ['red', 'green', 'blue', 'orange']
# criar gráfico
# plt.plot(equipas, pontos)
plt.bar(equipas, pontos, color=cores)

# acrescentar titulos
plt.title('Campeonato Portugal')
plt.xlabel('Equipas')
plt.ylabel('Pontuação')

# exibir o gráfico
plt.show()
