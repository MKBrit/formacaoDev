# biblioteca 'pandas'
# importar pandas
# instalar pandas -> pip install pandas [pypi.org]
# pip list -> quais as biblio instaladas
# pip freeze -> quais as biblio instaladas
import pandas as pd
import matplotlib.pyplot as plt

# criar variavel dataFrame (folha de cálculo) - df
df = pd.read_csv('population.csv') # carrega todos os dados do ficheiro para a variavel

# # ver as 5 primeiras linhas
# print(df.head())

# # ver as 5 ultimas linhas
# print(df.tail())

# # ver estatistica
# print(df.describe())

# # ver coluna country df['nome_coluna']
# print(df['country'])

# # soma todos os valores da coluna 'pop'
# total_pop = df['pop'].sum()
# print(total_pop)

# # a media de esperança de vida
# media_lifeExp = df['lifeExp'].mean()
# print(media_lifeExp)

# # minimo de esperança de vida
# minimo_lifeExp = df['lifeExp'].min()
# print(minimo_lifeExp)

# # maximo de esperança de vida
# maximo_lifeExp = df['lifeExp'].max()
# print(maximo_lifeExp)

# # soma de esperança de vida
# total_lifeExp = df['lifeExp'].sum()
# print(total_lifeExp)

# # contagem de paises
# num_pais = df['country'].count()
# print(num_pais)

# # media lifeExp por continente
media_lifeExp_continent = df.groupby('continent')['lifeExp'].mean()
# print(media_lifeExp_continent)

# # população total por continente
# total_pop_continent = df.groupby('continent')['pop'].sum()
# # print(total_pop_continent)

# # definir o tamanho da tela
# plt.figure(figsize=(10, 6))

# # criar grafico
# total_pop_continent.plot(kind='bar', color='skyblue')

# # personalizar o gráfico
# plt.title("População por continente")
# plt.xlabel('continentes')
# plt.ylabel('População')
# plt.xticks(rotation=45)
# plt.grid(axis='y')

# # mostrar gráfico
# plt.show()

plt.figure(figsize=(10, 6))

plt.pie(media_lifeExp_continent, labels=media_lifeExp_continent.index, autopct='%1.1f%%', startangle=140)

# personalizar o gráfico
plt.title("População por continente")

# mostrar gráfico
plt.show()