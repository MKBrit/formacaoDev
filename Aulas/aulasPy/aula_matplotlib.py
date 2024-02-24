import matplotlib.pyplot as plt
import pandas as pd


df = pd.read_csv('population.csv')

total_pop_continent = df.groupby('continent')['pop'].sum()
# Dados
equipas = ['Benfica', 'Sporting', 'Porto', 'Braga']
pontos = [29, 29, 26, 20]
cores = ['red', 'blue', 'green', 'yellow']
# grafico x, y       x = horizontal, y = vertical

plt.plot(equipas, pontos)

# acrescentar titulos
plt.title('Campeonato Portugal')
plt.xlabel('Equipas')
plt.ylabel('Pontuação')
plt.xticks(axis='x')


# show grafico
plt.show()