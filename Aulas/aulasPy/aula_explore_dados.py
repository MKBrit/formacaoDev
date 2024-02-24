import pandas as pd 

df = pd.read_csv("vendas2122.csv")

# Drops duplicate values
df.drop_duplicates

# Remove Rows with Missing Values
df = df.dropna()

# Explore the Data
print(df.head())


# Step 5: Write Cleaned Data to a New CSV File
df.to_csv('cleaned_data.csv', index=False)




# The dropna() method in pandas has a how parameter that allows you to control which rows are 
# dropped based on the presence of NaN (Not a Number) values. The "how=" parameter can take the 
# following values:
#   'any': Drop a row if it contains any NaN values in any column.
#   'all': Drop a row only if all values in the row are NaN.