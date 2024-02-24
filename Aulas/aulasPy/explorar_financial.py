# importar biblio pandas
import pandas as pd

# carregar ficheiro
df = pd.read_csv('financial.csv', sep=';')

# excluir linhas vazias
df = df.dropna(how='all')

# excluir duplicados
df = df.drop_duplicates()

# excluir espaços em branco no inicio e fim
df = df.rename(columns=lambda x: x.strip())

# renomear a coluna Month Name para Month
df = df.rename(columns={'Month Name': 'Month'})

# alterar o pais 'United States of America' para 'USA'
df['Country'] = df['Country'].replace('United States of America', 'USA')

# criar df com as colunas pretendidas
df = df[['Country','Product', 'Year', 'Month','Sales', 'Profit']]

# converter dados para float
df['Profit'] = df['Profit'].str.replace(',','.').astype(float)
df['Sales'] = df['Sales'].str.replace(',','.').astype(float)

# gravar o ficheiro tratado
df.to_csv('financial_clean.csv', index=False)
