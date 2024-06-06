using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1_INA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("1. Numeros: ");
            int[] numeros = { 10, 20, 30, 40, 50 };
            foreach (int i in numeros)
            {
                CbNums1.Items.Add(i);
            }
            Console.Write(numeros.Length);
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("2. Numeros: ");
            numeros = new int[] { 5, 10, 15, 20, 25 };
            foreach (int i in numeros)
            {
                CbNums2.Items.Add(i);
                Console.Write(i + " ");
            }
            Console.Write(" | ");
            numeros[2] = 100;
            foreach (int i in numeros)
            {
                CbNewNums2.Items.Add(i);
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("3. Nombres: ");
            string[] nombres = { "Ana", "Luis", "Pedro", "Marta" };
            int index = Array.IndexOf(nombres, "Pedro");
            Console.WriteLine(index);
            if (index != -1)
            {
                LblName.Text = $"Pedro en posicion {index}";
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("4. Numeros: ");
            numeros = new int[] { 50, 40, 30, 20, 10 };
            foreach (int i in numeros)
            {
                CbNums3.Items.Add(i);
                Console.Write(i + " ");
            }
            Console.Write(" | ");
            Array.Sort(numeros);
            foreach (int i in numeros)
            {
                CbNewNums3.Items.Add(i);
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("5. Numeros: ");
            numeros = new int[] { 1, 2, 3, 4, 5 };
            Array.Reverse(numeros);
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("6. Numeros: ");
            Array.Clear(numeros, 1, 3);
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("7. Numeros: ");
            int[] origen = { 1, 2, 3, 4, 5 };
            int[] destino = new int[origen.Length];
            Array.Copy(origen, destino, origen.Length);
            foreach (int i in destino)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("8. Numeros: ");
            numeros = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine(Array.Find(numeros, n => n > 20));
            Console.WriteLine("------------------");
            Console.WriteLine("9. Numeros: ");
            int[] valores = { 1, 3, 5, 7, 9 };
            Console.WriteLine(Array.Exists(valores, n => n > 6));
            Console.WriteLine("------------------");
            Console.WriteLine("10. Numeros: ");
            numeros = new int[] { 2, 4, 6, 8, 10 };
            Console.WriteLine(Array.Find(numeros, n => n % 2 == 0));
            Console.WriteLine("------------------");
            Console.WriteLine("11. Numeros: ");
            string[] frutas = { "manzana", "banana", "naranja", "kiwi" };
            Console.WriteLine(Array.IndexOf(frutas, "kiwi"));
            Console.WriteLine("------------------");
            Console.WriteLine("12. Numeros: ");
            numeros = new int[] { 15, 25, 35, 45, 55, 66 };
            Array.Clear(numeros, 2, 4);
            foreach (int i in numeros)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("13. Numeros: ");
            int[] datos = { 5, 10, 15, 20, 25 };
            int[] SubDatos = new int[3];
            Array.Copy(datos, SubDatos, 3);
            foreach (int i in SubDatos)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("14. Numeros: ");
            valores = new int[] { 3, 6, 9, 12, 15 };
            Array.Reverse(valores);
            foreach (int i in valores)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("15. Numeros: ");
            numeros = new int[] { 5, 10, 15, 20, 25 };
            Console.WriteLine(Array.Exists(numeros, n => n == 10));
            Console.WriteLine("------------------");
            Console.WriteLine("16. Numeros: ");
            Array.Sort(numeros);
            Console.WriteLine(numeros[0]);
            Console.WriteLine("------------------");
            Console.WriteLine("17. Numeros: ");
            Array.Sort(numeros);
            Console.WriteLine(numeros[numeros.Length - 1]);
            Console.WriteLine("------------------");
            Console.WriteLine("18. Numeros: ");
            int sum = 0;
            foreach (int item in numeros)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
