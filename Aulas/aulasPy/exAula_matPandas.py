import matplotlib.pyplot as plt
import pandas as pd

df = pd.read_csv('financial.csv')
print(df.describe)

# # excluir linhas vazias
# df = df.dropna(how='all')
# # excluir duplicados
# df = df.drop_duplicates()
# # excluir espaços em branco no inicio e fim
# df = df.rename(columns=lambda x: x.strip())
# # Rename columns
# df['Country'] = df['Country'].replace('United States of America', 'USA')

# # excluir espaços em branco no inicio e fim de cada coluna 
# rows = ['Product', 'Country', 'Month number']
# for row in rows:
#     df[row] = df[row].str.strip()

# or

# # Apply str.strip() to all values in the DataFrame
# df = df.map(lambda x: x.strip() if isinstance(x, str) else x)

# # convert numbers to float
# col = ['Units Sold', "Manufacturing Price", "Sale Price", "Gross Sales", "Discounts", "Sales", "COGS", "Profit"]
# for n in col:
#     print(df[n].astype)
#     df[n] = df[n].astype(str)
#     df[n] = df[n].str.replace(',','.')
#     df[n] = df[n].astype(float)


# print(df['Month Number'].drop_duplicates())
# print(df['Sales'].astype)

# Save the modified DataFrame to a new CSV file
# df.to_csv('financial.csv', index=False)




# Não acho que tenhamos dado conteúdo suficiente para fazer isto corretamente até ao fim
# Posso estar enganado, mas não estou a conseguir avançar daqui sem ter que recorrer à net
# E não tenho nada nos meus apontamentos que me ajudem a decifrar o próximo passo para avançar


print(df.columns)
vendasAno = df.groupby('Year')['Sales'].sum()
print(vendasAno)


vendasAno.plot(kind='bar', xlabel='Ano', ylabel='Vendas', title='Vendas por Ano')

df['Date'] = pd.to_datetime(df['Date'])

df['Year'] = df['Date'].dt.year
df['Month'] = df['Date'].dt.month_name()

vendasAnoMes = df.groupby(['Year', 'Month'])['Sales'].sum()

print(vendasAnoMes)
lucroAno = df.groupby('Year')['Profit'].sum()

lucroAno.plot(kind='bar', xlabel='Ano', ylabel='Lucro', title='Lucro por Ano')

profit_by_year = df.groupby('Year')['Profit'].sum()

profit_by_year.plot(kind='bar', xlabel='Ano', ylabel='Lucro', title='Lucro por Ano')

top_clients = df.groupby('Country')['Sales'].sum().nlargest(5)

top_clients.plot(kind='bar', xlabel='Cliente', ylabel='Vendas', title='Top 5 Clientes')

topLucro = df.groupby('Product')['Profit'].sum().nlargest(5)

topLucro.plot(kind='bar', xlabel='Produto', ylabel='Lucro', title='Top 5 Produtos por Lucro')

plt.show()