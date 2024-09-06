
bool condicion = true;
while (condicion == true)

{
    Clases.color_R();

    Console.WriteLine(@"

              _________
             {_________}
              )=======(
             /         \
            | _________ |
            ||   _     ||
            ||  |_)    ||
            ||  | \/   ||
      __    ||    /\   ||
 __  (_|)   |'---------'|
(_|)     jgs`-.........-'


1) Registrar vacunado.
2) Exportar tarjeta de vacunación a HTML 
3) Configuración (provincias, marcas de vacunas)
4) sobre mi
5) salir
");
    Clases.color_R();

    Console.Write("ingrese un datos de entrada: ");
    Clases.color_R();
    string entrada = Console.ReadLine() ?? "";

    switch (entrada)
    {
        case "1":
            Clases.color_R();
            Clases.Vacunados();
            break;
        case "2":
            Clases.color_R();
            Clases.Exportacion();
            break;
        case "3":
            Clases.color_R();
            Clases.configuracion();
            break;
        case "4":
            Console.Clear();
            Clases.color_R();
            Clases.Acerca_de();
            Console.ReadKey();

            break;
        case "5":
            condicion = false;

            break;
    }
    Console.Clear();




}