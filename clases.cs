using System;
using Microsoft.EntityFrameworkCore;

public class Clases
{
    public static void configuracion()
    {
        Console.Clear();
        var condicion = true;
        while (condicion)
        {
            color_R();
            Console.WriteLine(@"

                              ______________
                             [______________]
                              {============}
                            .-'  ,.--.     '-.
                           / --. /8888\ ,.--. \
                          / 8888\\8888///8888\ \
                          |--------------------|
                          |                    |
                          |      |\ | \  /     |
                          |      | \|  \/      |
                          |  ___  _    _   _   |
                          |   |  /_\  |_) (_   |
                          |   | /   \ |_) \_)  |
-cfbd-   ,.--.   ,.--.    |____________________|
After   //8888\ //8888\   |  \\8888/ \\8888/   |
 jgs    \\8888/ \\8888/   |   `'--'   `'--'    |
         `'--'   `'--'    '--------------------'

1) provincias
2) marcas de vacunas
3) atras
");
            color_R();
            Console.Write("ingrese una opcion :");
            var entrada = Console.ReadLine();
            switch (entrada)
            {
                case "1":
                    Provincias();
                    break;
                case "2":
                    Vacunas();
                    break;
                case "3":
                    condicion = false;
                    break;
            }


        }

    }
    public static void Provincias()
    {
        var db = new CovidContext();

        var condicion = true;
        while (condicion == true)
        {
            color_R();
            Console.WriteLine(@"
                                    +              #####
                                   / \
 _____        _____     __________/ o \/\_________      _________
|o o o|_______|    |___|               | | # # #  |____|o o o o  | /\
|o o o|  * * *|: ::|. .|               |o| # # #  |. . |o o o o  |//\\
|o o o|* * *  |::  |. .| []  []  []  []|o| # # #  |. . |o o o o  |((|))
|o o o|**  ** |:  :|. .| []  []  []    |o| # # #  |. . |o o o o  |((|))
|_[]__|__[]___|_||_|__<|____________;;_|_|___/\___|_.|_|____[]___|  |

1) agregar
2) editar
3) eliminar
4) atras
");
            color_R();
            Console.Write("ingrese una opcion :");
            color_R();
            var entrada = Console.ReadLine();
            switch (entrada)
            {
                case "1":
                    Console.Clear();






                    Console.WriteLine("vamos a agregar a una provincia");

                    Console.Write("introduce una provincia :");

                    var p = new Provincia();
                    p.Nombre = Console.ReadLine() ?? "";


                    db.Provincias.Add(p);
                    db.SaveChanges();


                    Console.WriteLine("provincia agregada");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("vamos a editar a una provincia");
                    Console.Write("introduce una provincia :");

                    List<Provincia> Provincias = db.Provincias.ToList();
                    foreach (var item in Provincias)
                    {
                        Console.WriteLine($" {item.Id} - {item.Nombre}");
                    };


                    var editar = db.Provincias.Find(int.Parse(Console.ReadLine()));
                    if (editar == null)
                    {

                        Console.WriteLine("no se encontro la provincia");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write($"ingrese el nombre de la provincia : ({editar.Nombre}) :");
                        editar.Nombre = Console.ReadLine() ?? "";
                        db.SaveChanges();
                        Console.WriteLine($"provincia editada");
                    };


                    Console.ReadKey();


                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("seleccione la Provincia");
                    List<Provincia> Provincias2 = db.Provincias.ToList();
                    foreach (var item in Provincias2)
                    {
                        Console.WriteLine(@$"
{item.Id} -- {item.Nombre}
--------------------------
");
                    };
                    var editar1 = db.Provincias.Find(int.Parse(Console.ReadLine()));
                    if (editar1 == null)
                    {

                        Console.WriteLine("no se encontro la provincia");
                        Console.ReadKey();
                    }
                    else
                    {
                        db.Provincias.Remove(editar1);
                        db.SaveChanges();

                        Console.WriteLine("provincia eliminada");
                    };

                    break;
                case "4":
                    condicion = false;
                    break;
            }
            Console.Clear();
        }

    }

    public static void Vacunas()
    {
        var db = new CovidContext();

        var condicion = true;
        color_R();
        while (condicion == true)
        {
            Console.Clear();

            Console.WriteLine(@"

.     |___________________________________
|-----|- - -|''''|''''|''''|''''|''''|'##\|__
|- -  |  cc 6    5    4    3    2    1 ### __]==----------------------
|-----|________________________________##/|
      |""""""""""""""""""""""""""""""""""

1) agregar vacuna 
2) editar vacuna
3) eliminar vacuna
4) atras
"); color_R();

            Console.Write("ingrese una opcion :");
            var entrada = Console.ReadLine();
            switch (entrada)
            {
                case "1":
                    Console.Clear();




                    color_R();

                    Console.WriteLine("vamos a agregar a una vacuna");

                    Console.Write("introduce una vacuna :");

                    var p = new Vacuna();
                    p.Nombre = Console.ReadLine() ?? "";


                    db.Vacunas.Add(p);
                    db.SaveChanges();

                    color_R();
                    Console.WriteLine("Vacuna agregada");
                    Console.ReadKey();
                    break;
                case "2":
                    color_R();
                    Console.WriteLine("vamos a editar a una vacuna");
                    Console.Write("introduce una vacuna :");

                    List<Vacuna> Vacunas = db.Vacunas.ToList();
                    foreach (var item in Vacunas)
                    {
                        Console.WriteLine($" {item.Id} - {item.Nombre}");
                    };


                    var editar = db.Vacunas.Find(int.Parse(Console.ReadLine()));
                    if (editar == null)
                    {
                        color_R();
                        Console.WriteLine("no se encontro la vacuna");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write($"ingrese el nombre de la vacuna: ({editar.Nombre}) :");
                        editar.Nombre = Console.ReadLine() ?? "";
                        db.SaveChanges();
                        Console.WriteLine("vacuna editada");
                    };


                    Console.ReadKey();


                    break;

                case "3":
                    Console.Clear();
                    color_R();
                    Console.WriteLine("seleccione la vacuna");
                    List<Vacuna> Vacunas2 = db.Vacunas.ToList();
                    foreach (var item in Vacunas2)
                    {
                        Console.WriteLine(@$"
{item.Id} -- {item.Nombre}
--------------------------
");
                    };
                    var editar1 = db.Vacunas.Find(int.Parse(Console.ReadLine()));
                    if (editar1 == null)
                    {

                        Console.WriteLine("no se encontro la vacuna");
                        Console.ReadKey();
                    }
                    else
                    {
                        db.Vacunas.Remove(editar1);
                        db.SaveChanges();

                        Console.WriteLine("vacuna eliminada");
                    };

                    break;
                case "4":
                    condicion = false;
                    break;
            }
            Console.Clear();
        }

    }
    public static void Vacunados()
    {

        Console.Clear();
        var db = new CovidContext();
        var Proseso = new Proceso();
        color_R();
        Console.WriteLine("Registro");
        var p = new Persona();
        color_R();
        Console.Write("ingrese la cedula(sin guiones) :");
        color_R();
        var cosas = 0;
        int.TryParse(Console.ReadLine(), out cosas);

        var Cedula = cosas;

        p = db.Personas.Where(a => a.Cedula == Cedula).FirstOrDefault();
        if (p == null)
        {
            p = new Persona();
            p.Cedula = Cedula;
            color_R();
            Console.Write("ingrese Nombre :");
            p.Nombre = Console.ReadLine();
            color_R();
            Console.Write("ingrese la Apellido :");
            p.Apellido = Console.ReadLine();
            color_R();
            Console.Write("ingrese la edad :");
            p.Edad = Console.ReadLine();
            color_R();

           

            db.Personas.Add(p);
         

        }
        p.Cedula = Cedula;
        db.Personas.Add(p);
        Console.Write("ingrese centro de vacunacion :");
        p.Centro = Console.ReadLine() ?? "uno hay";

        Console.Write("ingrese nombre de vacunador :");
        p.vacunador = Console.ReadLine() ?? "uno hay";
        Proseso.Persona = p;
        Proseso.fecha = DateTime.Now;
        var ListadosVacuna = db.Vacunas.ToList();
        foreach (var vac in ListadosVacuna)
        {
            color_R();
            Console.WriteLine($"{vac.Id} - {vac.Nombre}");
        }
        while (Proseso.Vacuna == null)
        {


            Console.Write("ingrese el id de la vacuna:");
            var vacuna = db.Vacunas.Find(int.Parse(Console.ReadLine()));
            if (vacuna == null)
            {
                color_R();
                Console.WriteLine("no se encontro la vacuna");
            }
            else
            {
                Proseso.Vacuna = vacuna;
            }

        }
        var ListadosProvincias = db.Provincias.ToList();
        foreach (var vacc in ListadosProvincias)
        {
            Console.WriteLine($"{vacc.Id} - {vacc.Nombre}");
        }
        while (Proseso.Provincia == null)
        {
            color_R();

            Console.Write("ingrese el id de la provincia :");
            var Provincias = db.Provincias.Find(int.Parse(Console.ReadLine()??""));
            if (Provincias == null)
            {
                Console.WriteLine("no se encontro la provincias");
            }
            else
            {
                Proseso.Provincia = Provincias;
            }

        }
        db.Procesos.Add(Proseso);
        db.SaveChanges();
        Console.WriteLine("vacunado registrado");
        Console.ReadKey();


    }

    public static void Exportacion()
    {
        var db = new CovidContext();
        color_R();
        Console.WriteLine("imprimir targeta");
        Persona persona = null;
        while (persona == null)
        {
            Console.Write("imprimir targeta o -1 para ver listado:");
            var cedula = 0;
            int.TryParse(Console.ReadLine(), out cedula);
            if (cedula == -1){
                var listadosPersonajes = db.Personas.ToList();
                foreach (var item in listadosPersonajes)
                {
                    Console.WriteLine($"{item.Id} : {item.Cedula} - {item.Nombre} - {item.Apellido} ");
                };
                color_R();
                Console.Write("introdusca id de persona");
                int.TryParse(Console.ReadLine(), out cedula);

                persona = db.Personas.Find(cedula);
            }
            else
            {
                persona = db.Personas.Where(x => x.Cedula == cedula).FirstOrDefault();
            }

        }
        var listadoProsesos = db.Procesos.Where(x => x.Persona.Id == persona.Id).Include(x => x.Vacuna).
            Include(x => x.Provincia).ToList();
        Console.WriteLine($"{persona.Nombre}{persona.Apellido}");

        var targeta = "";
        var targeta2 = "";
        var coco = "";

        int aumento = 0;
        var vf = "";
;
        foreach (var item in listadoProsesos)
        {
            vf = item.Persona.Centro;
            aumento++;
            Console.WriteLine($"{item.Id}{item.Vacuna.Nombre} - {item.Provincia.Nombre} - {item.fecha}");
            targeta += $@"


                    
                    <tr class='ttt'>
                        <th scope='row'>{aumento}. dosis covid-19</th>
                        <td class='letra_fea'>{item.Vacuna.Nombre}</td>
                        <td class='letra_fea'>{item.Provincia.Nombre}</td>
                        <td class='letra_fea'>{item.fecha}</td>
                    </tr>

                </tbody>

";
            targeta2 += $@"                                <tbody>
                                    <tr>
                                        <th scope='row'>vacunador dosis {aumento}</th>
                                        <td class='letra_fea'>{item.Persona.vacunador}</td>
                                 
                                    </tr>
                                </tbody>";

            coco = $@" <tbody>
                        <tr>
                            <th scope='row'>Nombre y Apellido</th>
                            <td class='letra_fea'>{item.Persona.Nombre} {item.Persona.Apellido}</td>

                        </tr>
                        <tr>
                            <th scope='row'>Edad</th>
                            <td class='letra_fea' >{item.Persona.Edad}</td>

                        </tr>
                        <tr>
                            <th scope='row '>Documento de identidad</th>
                            <td class='letra_fea'>{item.Persona.Cedula}</td>

                        </tr>
                    </tbody>";

        }
        
        var html = $@"<!doctype html>
<html lang='es'>

<head>
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <title>vacunacion de covid</title>


    <link rel='icon' type='image/png'
        href='https://static.wikia.nocookie.net/logopedia/images/c/c4/Logo-vacunateRD.png/revision/latest?cb=20210604154003' />
    <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css' rel='stylesheet'
        integrity='sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor' crossorigin='anonymous'>

        <style>
            @import url('https://fonts.googleapis.com/css2?family=Nanum+Brush+Script&display=swap');
            .letra_fea{{
             font-family: 'Nanum Brush Script', cursive;
                font-weight: 900;
                font-size: 30px;
            }}
            *{{
                margin: 0px;
                padding: 0px;



            }}
            .tarjeta{{
border: 3px solid rgb(0, 0, 124);;
margin:auto ;
position:relative;
margin-top:10px ;
margin-bottom:90px ;
width: 70%;
height: auto;
padding-top: 5px;
border-radius: 40px;
padding: 15px;
overflow: hidden;


            }}
           .lado_i *{{
                margin-bottom: 8px;
                margin-left:5px ;
            }}
        .lado_i img{{
            margin-left: 10px;

            width: 150px;
        }}
        .lado_i h1{{
            color: rgb(0, 0, 104);
            z-index: 1000;
            width: 800px;
            font-size: 25px;
            text-transform:uppercase;
            font-weight: 700;
        }}
        .cuadro{{
background-color: rgb(0, 0, 80);
color: #fff;
text-align: center;
width: 80%;
border-radius:5px ;
font-weight: 600;
text-transform:uppercase;
font-size: 15px;
margin-top: 15px;

        }}
        .arriba{{
            margin: auto;
            padding: 1PX;

        }}

        .corto {{
            display: flex;
            flex-direction: row-reverse;
        }}
        .corto img{{
            width: 100px;
    
            margin: 10px;
        }}
        .cc{{
            text-align: center;
        }}
        .cc h2{{
            border-bottom:1px solid rgb(49, 49, 49) ;
            width: 80%;
            margin: auto;
            
        }}

        .lado_i h6{{
            color: rgba(19, 19, 19, 0.459);
            text-transform:uppercase;
        }}
.abajo{{
margin-top: 20px;
display: flex;
justify-content: center;
}}
.cabeza{{
font-size: 10px;
text-align: center;
background-color: rgb(0, 0, 80);
border-radius: 3px;
margin: auto;
color: #fff;
}}
.table{{
    margin: auto;
}}
.table th{{
border-right: rgb(204, 204, 204)1px solid;
}}
.cabeza h1{{
font-size: 20px;
margin:1px ;

}}

.tbody{{
    margin-top: 100px;
}}
.caca{{

}}

.tt td{{
    border-right: rgb(204, 204, 204)1px solid;
    text-align: center;
    color: black;
     font-size: 15px;
}}
.ttt td{{
    border-right: rgb(204, 204, 204)1px solid;
    text-align: center;
    color: black;

}}


.tt * {{
margin: 0px;
}}

.lololol{{
    font-size: 15px;
}}


.barra{{

    z-index: 1000000;

    transform: scale(85%);
    position: relative;
    left: 55%;
    top: 20px;
filter: opacity(0.4);

}}
.sello{{
    z-index: 10000000;
    transform: scale(450%);
    position: relative;
    right:-20%;
    top: 140px;
filter: opacity(0.15);

}}
.corto .min{{
    width: 160px;
    z-index: 1000000000000000000;
    position: relative;
    left: 5%;
}}
.mono{{
    font-size: 20px;
    position: relative;
    top: 10px;
}}
td , tr , th{{
    width: 1px;
    height: 1px;
}}
</style>
</head>

<body>
    <div class=' tarjeta container'>
        <div class='row arriba'>
            <div class='col-6 lado_i'>
<img src='data:image/jpeg;base64,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' alt=''>

<img class='barra' src='data:image/png;base64,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' alt=''>
<h1> <strong>viceministerio de salud colectiva</strong> </h1>
<h6>programa amplio de inmunizacion</h6>
<div class='cuadro'>
    <p>targeta de vacunacion covid-19</p>
</div>

            </div>
            <div class='col-6 lado_d container-fluid'>
                <div class='row corto'>
<img src='https://propeep.gob.do/wp-content/uploads/2021/03/Logo-VacunateRd.png' alt=''>
<img class='min' src='https://pai.minsalud.gob.bo/images/logo-wide.png' alt=''>

<img class='sello' src='data:image/jpeg;base64,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' alt=''>

                </div>
                <div class='row cc'>
                    <h6>centro de vacunacion :</h6>
                    <div>
                        <!-- aqui ira el centro de vacunacion -->
                        <h2 class='letra_fea'>{vf}</h2>

                    </div>
                </div>


            </div>
        </div>
        <div class='row abajo container-fluid'>
            <div class='row caca'>
                <table class='table'>
                    <thead class='cabeza'>
                        <div class='cabeza'>
                            <h1>DATOS PERSONALES</h1>
                        </div>

                    </thead>
                   {coco}
                </table>

            </div>
            <div class='row caca'> <table class='table'>
                <thead class='cabeza'>
                    <div class='cabeza'>
                        <h1>DATOS DE VACUNACION</h1>
                    </div>
                </thead>

                <!--aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-->>
                <tbody>
                    <tr class='ttt mono'>
                        <td>dosis</td>
                        <td>Laboratorio</td>
                        <td>provincia</td>
                        <td class='lololol'>
                            <p>fecha de vacunacion</p>
                            <p>(dia,mes,año)</p>
                        </td>
                    </tr>
{targeta}
 </tbody>
{targeta2}
            </table>
 </div>
        </div>
    </div>
    <script src='https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js'
        integrity='sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2'
        crossorigin='anonymous'></script>
</body>

</html>";
        System.IO.File.WriteAllText("index.html", html);
        Console.WriteLine("targeta creada");


        var uri = "index.html";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);



        

 


        Console.ReadKey();
    }

    public static void Acerca_de()
    {
        color_R();
        Console.WriteLine(@"
	  /$$$$$$   /$$     /$$                              
	 /$$__  $$ | $$    |__/                              
	| $$  \__//$$$$$$   /$$ /$$    /$$ /$$$$$$  /$$$$$$$ 
	|  $$$$$$|_  $$_/  | $$|  $$  /$$//$$__  $$| $$__  $$
	 \____  $$ | $$    | $$ \  $$/$$/| $$$$$$$$| $$  \ $$
	 /$$  \ $$ | $$ /$$| $$  \  $$$/ | $$_____/| $$  | $$
	|  $$$$$$/ |  $$$$/| $$   \  $/  |  $$$$$$$| $$  | $$
	 \______/   \___/  |__/    \_/    \_______/|__/  |__/
                                                     
	 ___   ___  ___   ___        ___    __   ___  ___ 
	(__ \ / _ \(__ \ (__ \ ___  / _ \  /. | | __)(__ )
	 / _/( (_) )/ _/  / _/(___)( (_) )(_  _)|__ \ / / 
	(____)\___/(____)(____)     \___/   (_) (___/(_/                                                       
                                             
"); color_R();
        Console.WriteLine(@"

matricula : 2022-0457
nombre : Stiven 
apellido : de la rosa brito 







");







    }

    

    public static void color_R()
    {

        Random r = new Random();

        int coco = r.Next(1, 9);

        if (coco == 1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (coco == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (coco == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (coco == 4)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (coco == 5)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (coco == 6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (coco == 7)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if (coco == 8)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        else if (coco == 9)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }



    }


    public static void Salida_color(string entrada, string color)
    {
        //ConsoleColor.Blue;

        if (color == "rojo")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }


        Console.WriteLine(entrada);
        Console.ResetColor();

    }

}

