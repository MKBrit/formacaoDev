import tkinter as tk




def add_nome():
    item = entry_nome.get() # Obter text da caixa de entrada

    if item:    # Testa se a caixa de entrada tem texto
        listbox_mostrar.insert(tk.END, item)    # Insere os dados no fim da listbox
        entry_nome.delete(0, tk.END)    # Limpa a caixa da entrada

#   Cria a janela
window = tk.Tk()

#   Tamanho da janela
window.geometry("400x500")

#   Titulo da janela--
window.title("Pokemon Bot")


#   Adicionar uma etiqueta à window
label_nome = tk.Label(window,text="Nome:") # cria label
label_nome.pack(pady=10) # pady = 10 -> dá 10 pixels de espaço na vertical

#   Adicionar um botão
button_add = tk.Button(window,text="Adicionar", command=add_nome)
button_add.pack(pady=10)

#   Adicionar uma checkbox
button_add0 = tk.Checkbutton(window,text="Adicionar", command=add_nome)
button_add1 = tk.Checkbutton(window,text="Adicionar", command=add_nome)
button_add2 = tk.Checkbutton(window,text="Adicionar", command=add_nome)
button_add3 = tk.Checkbutton(window,text="Adicionar", command=add_nome)
button_add4 = tk.Checkbutton(window,text="Adicionar", command=add_nome)
button_add0.pack(pady=10)
button_add1.pack(pady=10)
button_add2.pack(pady=10)
button_add3.pack(pady=10)
button_add4.pack(pady=10)

#   Adicionar entrada (rectangulo para escrever)
entry_nome = tk.Entry(window)
entry_nome.pack(pady=10)

#   Adicionar uma lista
listbox_mostrar = tk.Listbox(window, width=50, height=30)
listbox_mostrar.pack(pady=10)

############################        Main loop       ############################


window.mainloop()

