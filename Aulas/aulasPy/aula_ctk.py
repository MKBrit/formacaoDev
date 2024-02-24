import customtkinter as ctk

main = ctk.CTk()

main.title("Pokemon Planet Online Bot")
main.geometry("500x600")
main.resizable(width=False, height=False)


def abrir():
    diagbox= ctk.CTkInputDialog(title=main.title, text="Vá po crl")
    print("Caralho inserido com sucesso, venha-se", diagbox.get_input())


btn = ctk.CTkButton(main, text="Start", command=abrir)
btn.pack()











main.mainloop()