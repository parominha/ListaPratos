using System;
using System.Collections.Generic;

namespace ListaPratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Pratos");

            List<Prato> pratos = new List<Prato>();

            pratos.Add(new Prato("Macarronada", "Macarrão, sal, óleo, molho de tomate, carne moida e cebola", "Macarrão com molho", "https://img.cybercook.com.br/receitas/33/macarronada-4-840x480.jpeg?q=75", "30 minutos"));
            pratos.Add(new Prato("Feijão", "Feijão cru, água, sal, óleo, alho", "Feijão fresco", "https://img.itdg.com.br/tdg/images/recipes/000/169/692/146782/146782_original.jpg?mode=crop&width=710&height=400", "1 hora"));
            pratos.Add(new Prato("Pizza de Pepperoni", "Molho de tomate, água, orégano, cebola, sal, queijo parmesão, azeite, fermento, farinha de trigo, queijo mussarela, pepperoni", "Pizza de Pepperoni inspirada no Pizza Hut (Massa Pan)", "https://receitasdeminuto.com/wp-content/uploads/2019/11/pizza_pan_pizza_hut.jpg", "1 hora"));

        }
    }
}
