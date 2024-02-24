import pandas as pd
import matplotlib.pyplot as plt

# para ler o ficheiro quando está num subdiretório "path/filename.txt"
df = pd.read_csv('population.csv')

# head - primeiras 5 linhas
print(df.head())

# ver coluna 'country'
print(df['country'])

# tail - ultimas 5 linhas
print(df.tail())

# soma valores da coluna 'pop'
total_pop = df['pop'].sum()
print(total_pop)

# a media de esp vida
media_lifexp = df['lifeExp'].mean()
print(media_lifexp)

# o min de esp vidaad
minimo_lifexp = df['lifeExp'].min()
print(minimo_lifexp)

# o max de esp vida
maximo_lifexp = df['lifeExp'].max()
print(maximo_lifexp)

# o total de esp vida
total_lifexp = df['lifeExp'].sum()
print(total_lifexp)

# media lifeExp por continente
media_lifeExp_continent = df.groupby('continent')['lifeExp'].mean()
print(media_lifeExp_continent)

avg_life_exp_by_continent = df.groupby('continent')['lifeExp'].mean()
print(avg_life_exp_by_continent)

# Create a pie chart
plt.figure(figsize=(8, 8))
plt.pie(avg_life_exp_by_continent, labels=avg_life_exp_by_continent.index, autopct='%1.1f%%', startangle=140)

plt.show()