using di_ra5_proyecto_Cesar_Aganzo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra5_proyecto_Cesar_Aganzo.Controlador
{
    /// <summary>
    /// Clase estática que gestiona el estado global de la aplicación y mantiene listas principales de datos.
    /// </summary>
    public static class ControlApp
    {
        /// <summary>
        /// Indica si la aplicación debe abrir el formulario FAQ.
        /// </summary>
        public static bool aFaq = false;
        /// <summary>
        /// Indica si la aplicación debe abrir el formulario Ayuda.
        /// </summary>
        public static bool aAyuda = false;
        /// <summary>
        /// Indica si la aplicación debe cerrarse.
        /// </summary>
        public static bool salir = false;
        /// <summary>
        /// Controla si se omiten ciertas confirmaciones en la aplicación.
        /// </summary>
        public static bool noPregunta = false;
        /// <summary>
        /// Marca si un elemento debe ser eliminado.
        /// </summary>
        public static bool toDelete = false;
        /// <summary>
        /// Lista principal que almacena todos los coches registrados en la aplicación.
        /// </summary>
        public static List<Coche> listCoches = new List<Coche>
        {
            new Coche(1, "Opel", "Corsa",1400,1500.23,new DateTime(2002, 03, 15),false),
            new Coche(2, "Ford", "Focus", 1600, 20000.00, new DateTime(2015, 06, 20), false),
            new Coche(3, "BMW", "X5", 3000, 75000.00, new DateTime(2022, 01, 05), false),
            new Coche(4, "Mercedes", "CLA", 2000, 40000.00, new DateTime(2021, 10, 10), true),
            new Coche(5, "Toyota", "Corolla", 1800, 25000.00, new DateTime(2020, 08, 30), false),
            new Coche(6, "Volkswagen", "Golf", 1400, 22000.00, new DateTime(2018, 02, 12), false),
            new Coche(7, "Audi", "A4", 1900, 35000.00, new DateTime(2019, 07, 25), false),
            new Coche(8, "Mazda", "MX-5", 2000, 30000.00, new DateTime(2021, 05, 18), true),
            new Coche(9, "Honda", "Civic", 1600, 21000.00, new DateTime(2017, 11, 05), false),
            new Coche(10, "Hyundai", "Tucson", 2500, 28000.00, new DateTime(2016, 04, 01), false),
            new Coche(11, "Chevrolet", "Camaro", 3600, 55000.00, new DateTime(2020, 09, 12), true),
            new Coche(12, "Tesla", "Model 3", 0, 45000.00, new DateTime(2022, 03, 15), false),
            new Coche(13, "Nissan", "Altima", 2000, 24000.00, new DateTime(2019, 08, 24), false),
            new Coche(14, "Peugeot", "208", 1200, 18000.00, new DateTime(2020, 10, 05), false),
            new Coche(15, "Renault", "Megane", 1600, 20000.00, new DateTime(2018, 12, 01), false),
            new Coche(16, "Kia", "Sportage", 2400, 27000.00, new DateTime(2021, 07, 10), false),
            new Coche(17, "Jeep", "Wrangler", 3000, 45000.00, new DateTime(2020, 02, 19), true),
            new Coche(18, "Fiat", "500", 900, 16000.00, new DateTime(2019, 05, 14), false),
            new Coche(19, "Porsche", "911", 3000, 100000.00, new DateTime(2022, 06, 15), true),
            new Coche(20, "Lamborghini", "Huracan", 5200, 300000.00, new DateTime(2023, 01, 10), true),
            new Coche(21, "Ferrari", "488", 3900, 250000.00, new DateTime(2023, 02, 11), true),
            new Coche(22, "Bugatti", "Chiron", 8000, 3000000.00, new DateTime(2023, 03, 01), true),
            new Coche(23, "McLaren", "720S", 4000, 280000.00, new DateTime(2023, 01, 25), true),
            new Coche(24, "Jaguar", "F-Type", 3000, 70000.00, new DateTime(2021, 09, 12), true),
            new Coche(25, "Mini", "Cooper", 1500, 23000.00, new DateTime(2020, 11, 03), false),
            new Coche(26, "Subaru", "Outback", 2500, 27000.00, new DateTime(2019, 07, 22), false),
            new Coche(27, "Volvo", "XC90", 2000, 65000.00, new DateTime(2022, 02, 20), false),
            new Coche(28, "Alfa Romeo", "Giulia", 2100, 43000.00, new DateTime(2021, 05, 08), false),
            new Coche(29, "Seat", "Ibiza", 1400, 19000.00, new DateTime(2018, 10, 15), false),
            new Coche(30, "Skoda", "Octavia", 2000, 25000.00, new DateTime(2019, 03, 12), false),
            new Coche(31, "Mitsubishi", "Lancer", 1800, 23000.00, new DateTime(2020, 01, 04), false),
            new Coche(32, "Suzuki", "Swift", 1300, 17000.00, new DateTime(2019, 08, 01), false),
            new Coche(33, "Dodge", "Charger", 4000, 50000.00, new DateTime(2021, 03, 11), false),
            new Coche(34, "Cadillac", "Escalade", 6200, 90000.00, new DateTime(2021, 12, 31), false),
            new Coche(35, "Citroen", "C3", 1200, 15000.00, new DateTime(2018, 11, 14), false),
            new Coche(36, "Rolls Royce", "Phantom", 7000, 450000.00, new DateTime(2022, 08, 10), true),
            new Coche(37, "Aston Martin", "DB11", 4000, 200000.00, new DateTime(2023, 01, 18), true),
            new Coche(38, "Bentley", "Continental GT", 6000, 250000.00, new DateTime(2023, 02, 22), true),
            new Coche(39, "Pagani", "Zonda", 7500, 1500000.00, new DateTime(2023, 03, 05), true),
            new Coche(40, "Koenigsegg", "Jesko", 5000, 3000000.00, new DateTime(2023, 03, 30), true),
            new Coche(41, "Tesla", "Model S", 0, 80000.00, new DateTime(2021, 04, 20), false),
            new Coche(42, "Lucid", "Air", 0, 100000.00, new DateTime(2022, 07, 25), false),
            new Coche(43, "Chevrolet", "Spark", 1200, 14000.00, new DateTime(2020, 06, 11), false),
            new Coche(44, "Ford", "Mustang", 5000, 55000.00, new DateTime(2021, 09, 15), true),
            new Coche(45, "Toyota", "Supra", 3000, 60000.00, new DateTime(2022, 01, 07), true),
            new Coche(46, "Nissan", "Skyline", 2800, 45000.00, new DateTime(2005, 03, 15), true),
            new Coche(47, "Mazda", "RX-7", 2000, 50000.00, new DateTime(1998, 12, 01), true),
            new Coche(48, "Lexus", "RX", 3000, 55000.00, new DateTime(2021, 11, 30), false),
            new Coche(49, "Hyundai", "Elantra", 1600, 20000.00, new DateTime(2019, 07, 04), false),
            new Coche(50, "Volkswagen", "Polo", 1000, 18000.00, new DateTime(2018, 05, 20), false)
        };
        /// <summary>
        /// Lista principal que almacena todos los productos registrados en la aplicación.
        /// </summary>
        public static List<Producto> productList = new List<Producto>
        {
            new Producto(1, "Pan", "Pan del día", 1.00, DateTime.Now.AddDays(1), 30),
            new Producto(2, "Zanahoria", "Zanahoria fresca", 0.20, DateTime.Now.AddDays(7), 10),
            new Producto(3, "Tomate", "Tomate rojo", 0.50, DateTime.Now.AddDays(7), 0),
            new Producto(4, "Pollo", "Pollo entero", 4.00, DateTime.Now.AddDays(5), 15),
            new Producto(5, "Hamburguesa", "Hamburguesas gourmet", 2.50, DateTime.Now.AddDays(10), 20),
            new Producto(6, "Salchichas", "Salchichas tradicionales", 1.20, DateTime.Now.AddDays(12), 5),
            new Producto(7, "Lechuga", "Lechuga fresca", 0.90, DateTime.Now.AddDays(3), 0),
            new Producto(8, "Manzana", "Manzanas dulces", 1.50, DateTime.Now.AddDays(14), 10),
            new Producto(9, "Yogur", "Yogur natural", 0.80, DateTime.Now.AddDays(6), 0),
            new Producto(10, "Queso", "Queso manchego", 3.50, DateTime.Now.AddDays(20), 5),
            new Producto(11, "Cerveza", "Cerveza rubia", 1.10, DateTime.Now.AddDays(30), 15),
            new Producto(12, "Agua", "Agua mineral", 0.60, DateTime.Now.AddDays(60), 0),
            new Producto(13, "Harina", "Harina de trigo", 0.90, DateTime.Now.AddDays(365), 0),
            new Producto(14, "Azúcar", "Azúcar refinado", 0.75, DateTime.Now.AddDays(180), 10),
            new Producto(15, "Arroz", "Arroz integral", 1.20, DateTime.Now.AddDays(200), 0),
            new Producto(16, "Pasta", "Pasta italiana", 1.30, DateTime.Now.AddDays(250), 0),
            new Producto(17, "Aceite", "Aceite de oliva", 4.20, DateTime.Now.AddDays(180), 5),
            new Producto(18, "Huevos", "Huevos frescos", 2.50, DateTime.Now.AddDays(15), 0),
            new Producto(19, "Leche", "Leche entera", 1.10, DateTime.Now.AddDays(10), 0),
            new Producto(20, "Pescado", "Pescado fresco", 6.50, DateTime.Now.AddDays(2), 10),
            new Producto(21, "Mantequilla", "Mantequilla cremosa", 1.80, DateTime.Now.AddDays(30), 0),
            new Producto(22, "Café", "Café molido", 3.00, DateTime.Now.AddDays(180), 20),
            new Producto(23, "Té", "Té verde", 2.20, DateTime.Now.AddDays(300), 15),
            new Producto(24, "Cereal", "Cereal integral", 2.50, DateTime.Now.AddDays(100), 0),
            new Producto(25, "Chocolate", "Chocolate negro", 2.80, DateTime.Now.AddDays(200), 10),
            new Producto(26, "Galletas", "Galletas dulces", 1.90, DateTime.Now.AddDays(120), 5),
            new Producto(27, "Mermelada", "Mermelada de fresa", 2.00, DateTime.Now.AddDays(180), 10),
            new Producto(28, "Carne", "Carne de res", 7.50, DateTime.Now.AddDays(3), 15),
            new Producto(29, "Jugo", "Jugo de naranja", 1.20, DateTime.Now.AddDays(7), 5),
            new Producto(30, "Champú", "Champú anticaspa", 3.50, DateTime.Now.AddDays(365), 0),
            new Producto(31, "Detergente", "Detergente líquido", 5.00, DateTime.Now.AddDays(400), 5),
            new Producto(32, "Esponja", "Esponjas multiuso", 0.80, DateTime.Now.AddDays(500), 0),
            new Producto(33, "Cepillo", "Cepillo dental", 1.00, DateTime.Now.AddDays(365), 0),
            new Producto(34, "Jabón", "Jabón de manos", 0.90, DateTime.Now.AddDays(700), 0),
            new Producto(35, "Cera", "Cera para pisos", 2.50, DateTime.Now.AddDays(800), 0),
            new Producto(36, "Vinagre", "Vinagre blanco", 1.30, DateTime.Now.AddDays(180), 5),
            new Producto(37, "Champiñones", "Champiñones frescos", 2.80, DateTime.Now.AddDays(5), 10),
            new Producto(38, "Pimienta", "Pimienta negra", 0.50, DateTime.Now.AddDays(365), 0),
            new Producto(39, "Sal", "Sal marina", 0.30, DateTime.Now.AddDays(365), 0),
            new Producto(40, "Especias", "Especias mixtas", 1.70, DateTime.Now.AddDays(365), 5),
            new Producto(41, "Frijoles", "Frijoles negros", 1.20, DateTime.Now.AddDays(300), 0),
            new Producto(42, "Lentejas", "Lentejas orgánicas", 1.50, DateTime.Now.AddDays(200), 5),
            new Producto(43, "Atún", "Atún enlatado", 2.30, DateTime.Now.AddDays(365), 0),
            new Producto(44, "Sardinas", "Sardinas enlatadas", 2.00, DateTime.Now.AddDays(365), 5),
            new Producto(45, "Helado", "Helado de vainilla", 3.50, DateTime.Now.AddDays(60), 10),
            new Producto(46, "Pizza", "Pizza congelada", 5.00, DateTime.Now.AddDays(30), 20),
            new Producto(47, "Tortilla", "Tortillas de maíz", 1.10, DateTime.Now.AddDays(7), 0),
            new Producto(48, "Pan integral", "Pan integral de avena", 1.20, DateTime.Now.AddDays(10), 10),
            new Producto(49, "Salsa", "Salsa de tomate", 1.50, DateTime.Now.AddDays(180), 5),
            new Producto(50, "Puré", "Puré de papas instantáneo", 2.50, DateTime.Now.AddDays(365), 0)
        };
        /// <summary>
        /// Lista principal que almacena todos los clientes registrados en la aplicación.
        /// </summary>
        public static List<Cliente> clienteList = new List<Cliente>
        {
            new Cliente(1, "Cesar", "ces@ejemplo.com", new DateTime(1984, 03, 15), true, 0.0),
            new Cliente(2, "Ana", "ana@ejemplo.com", new DateTime(1990, 07, 20), false, 150.5),
            new Cliente(3, "Carlos", "carlos@ejemplo.com", new DateTime(1985, 11, 10), true, 250.0),
            new Cliente(4, "Luisa", "luisa@ejemplo.com", new DateTime(1993, 02, 28), true, 0.0),
            new Cliente(5, "Jorge", "jorge@ejemplo.com", new DateTime(1978, 08, 15), false, 300.0),
            new Cliente(6, "María", "maria@ejemplo.com", new DateTime(1995, 12, 05), true, 100.0),
            new Cliente(7, "Juan", "juan@ejemplo.com", new DateTime(2000, 06, 18), false, 50.0),
            new Cliente(8, "Sofía", "sofia@ejemplo.com", new DateTime(1988, 04, 22), true, 0.0),
            new Cliente(9, "Ricardo", "ricardo@ejemplo.com", new DateTime(1992, 01, 03), false, 75.0),
            new Cliente(10, "Elena", "elena@ejemplo.com", new DateTime(1980, 09, 12), true, 200.0),
            new Cliente(11, "Pablo", "pablo@ejemplo.com", new DateTime(1982, 10, 25), false, 0.0),
            new Cliente(12, "Claudia", "claudia@ejemplo.com", new DateTime(1996, 03, 14), true, 90.0),
            new Cliente(13, "Javier", "javier@ejemplo.com", new DateTime(1987, 05, 06), false, 120.0),
            new Cliente(14, "Marta", "marta@ejemplo.com", new DateTime(1991, 08, 29), true, 50.0),
            new Cliente(15, "Gabriel", "gabriel@ejemplo.com", new DateTime(1975, 12, 31), false, 0.0),
            new Cliente(16, "Isabel", "isabel@ejemplo.com", new DateTime(1983, 07, 07), true, 175.0),
            new Cliente(17, "Tomás", "tomas@ejemplo.com", new DateTime(1998, 02, 11), false, 20.0),
            new Cliente(18, "Alicia", "alicia@ejemplo.com", new DateTime(1994, 11, 19), true, 60.0),
            new Cliente(19, "Hugo", "hugo@ejemplo.com", new DateTime(1999, 10, 10), false, 30.0),
            new Cliente(20, "Silvia", "silvia@ejemplo.com", new DateTime(1981, 06, 02), true, 100.0),
            new Cliente(21, "Mario", "mario@ejemplo.com", new DateTime(1986, 04, 27), false, 180.0),
            new Cliente(22, "Teresa", "teresa@ejemplo.com", new DateTime(1997, 05, 16), true, 250.0),
            new Cliente(23, "Francisco", "francisco@ejemplo.com", new DateTime(1979, 01, 01), false, 40.0),
            new Cliente(24, "Rosa", "rosa@ejemplo.com", new DateTime(1990, 09, 23), true, 0.0),
            new Cliente(25, "Eduardo", "eduardo@ejemplo.com", new DateTime(1984, 12, 12), false, 300.0),
            new Cliente(26, "Valeria", "valeria@ejemplo.com", new DateTime(1993, 03, 05), true, 50.0),
            new Cliente(27, "Diego", "diego@ejemplo.com", new DateTime(1985, 07, 25), false, 90.0),
            new Cliente(28, "Patricia", "patricia@ejemplo.com", new DateTime(1992, 08, 18), true, 10.0),
            new Cliente(29, "Andrés", "andres@ejemplo.com", new DateTime(1988, 10, 14), false, 0.0),
            new Cliente(30, "Verónica", "veronica@ejemplo.com", new DateTime(1980, 06, 30), true, 70.0),
            new Cliente(31, "Lucas", "lucas@ejemplo.com", new DateTime(1994, 02, 02), false, 15.0),
            new Cliente(32, "Camila", "camila@ejemplo.com", new DateTime(1989, 05, 24), true, 0.0),
            new Cliente(33, "Oscar", "oscar@ejemplo.com", new DateTime(1991, 09, 09), false, 120.0),
            new Cliente(34, "Lorena", "lorena@ejemplo.com", new DateTime(1986, 04, 17), true, 30.0),
            new Cliente(35, "Guillermo", "guillermo@ejemplo.com", new DateTime(1983, 11, 11), false, 250.0),
            new Cliente(36, "Daniela", "daniela@ejemplo.com", new DateTime(1995, 07, 04), true, 80.0),
            new Cliente(37, "Ignacio", "ignacio@ejemplo.com", new DateTime(1990, 01, 28), false, 100.0),
            new Cliente(38, "Paola", "paola@ejemplo.com", new DateTime(1987, 03, 21), true, 5.0),
            new Cliente(39, "Víctor", "victor@ejemplo.com", new DateTime(1999, 06, 12), false, 70.0),
            new Cliente(40, "Natalia", "natalia@ejemplo.com", new DateTime(1993, 12, 03), true, 0.0),
            new Cliente(41, "Emilio", "emilio@ejemplo.com", new DateTime(1978, 08, 08), false, 60.0),
            new Cliente(42, "Mónica", "monica@ejemplo.com", new DateTime(1981, 09, 15), true, 110.0),
            new Cliente(43, "Felipe", "felipe@ejemplo.com", new DateTime(1997, 03, 18), false, 90.0),
            new Cliente(44, "Laura", "laura@ejemplo.com", new DateTime(1996, 07, 21), true, 50.0),
            new Cliente(45, "Héctor", "hector@ejemplo.com", new DateTime(1989, 10, 09), false, 40.0),
            new Cliente(46, "Karina", "karina@ejemplo.com", new DateTime(1982, 12, 29), true, 0.0),
            new Cliente(47, "Sebastián", "sebastian@ejemplo.com", new DateTime(1994, 05, 15), false, 130.0),
            new Cliente(48, "Andrea", "andrea@ejemplo.com", new DateTime(1988, 11, 22), true, 0.0),
            new Cliente(49, "Fernando", "fernando@ejemplo.com", new DateTime(1992, 02, 04), false, 300.0),
            new Cliente(50, "Lucía", "lucia@ejemplo.com", new DateTime(1990, 08, 27), true, 200.0)
        };
        /// <summary>
        /// Lista principal que almacena todos los empleados registrados en la aplicación.
        /// </summary>
        public static List<Empleado> empleadosList = new List<Empleado>
        {
            new Empleado(1, "Marcos", "Mar@cos.com", new DateTime(2020, 01, 20), 4, 60000, true),
            new Empleado(2, "Paco", "Hern@andez.com", new DateTime(2020, 01, 15), 3, 45000, false),
            new Empleado(3, "Cesar", "Aga@nzo.com", new DateTime(2020, 01, 01), 5, 80000, false),
            new Empleado(4, "Javier", "Vill2egas.com", new DateTime(2021, 01, 23), 4, 60000, false),
            new Empleado(5, "Alverto", "Alon@so.com", new DateTime(2022, 02, 28), 4, 60000, false),
            new Empleado(6, "Elena", "Rodriguez@domain.com", new DateTime(2022, 01, 13), 3, 45000, true),
            new Empleado(7, "Marina", "Focaz@mail.com", new DateTime(2022, 01, 07), 3, 45000, false),
            new Empleado(8, "Javier", "Martinez@correo.com", new DateTime(2021, 01, 01), 3, 45000, false),
            new Empleado(9, "Homer", "Simpson@mail.com", new DateTime(2021, 01, 03), 3, 45000, false),
            new Empleado(10, "Maguie", "Salas@domain.com", new DateTime(2021, 02, 05), 3, 45000, true),
            new Empleado(11, "Luis", "Garcia@correo.com", new DateTime(2020, 02, 10), 4, 50000, false),
            new Empleado(12, "Andrea", "Perez@mail.com", new DateTime(2020, 03, 15), 3, 55000, true),
            new Empleado(13, "Raul", "Lopez@domain.com", new DateTime(2021, 06, 18), 5, 75000, true),
            new Empleado(14, "Sandra", "Hernandez@correo.com", new DateTime(2022, 07, 25), 4, 60000, false),
            new Empleado(15, "Esteban", "Martinez@mail.com", new DateTime(2023, 04, 11), 3, 45000, true),
            new Empleado(16, "Laura", "Gomez@domain.com", new DateTime(2022, 10, 09), 5, 80000, false),
            new Empleado(17, "Miguel", "Ruiz@mail.com", new DateTime(2021, 12, 20), 4, 60000, true),
            new Empleado(18, "Rocio", "Alvarez@correo.com", new DateTime(2022, 05, 22), 3, 45000, false),
            new Empleado(19, "Pedro", "Jimenez@domain.com", new DateTime(2023, 01, 16), 4, 50000, true),
            new Empleado(20, "Sofia", "Navarro@correo.com", new DateTime(2021, 11, 03), 4, 60000, false),
            new Empleado(21, "Manuel", "Ortega@mail.com", new DateTime(2023, 06, 07), 3, 45000, false),
            new Empleado(22, "Paula", "Torres@domain.com", new DateTime(2022, 02, 14), 5, 80000, true),
            new Empleado(23, "Victor", "Ramos@correo.com", new DateTime(2021, 03, 20), 4, 50000, false),
            new Empleado(24, "Clara", "Vega@mail.com", new DateTime(2022, 08, 08), 3, 45000, true),
            new Empleado(25, "Diego", "Castillo@domain.com", new DateTime(2020, 09, 09), 4, 60000, false),
            new Empleado(26, "Natalia", "Morales@correo.com", new DateTime(2021, 04, 30), 3, 45000, false),
            new Empleado(27, "Joaquin", "Cano@mail.com", new DateTime(2020, 12, 25), 5, 75000, true),
            new Empleado(28, "Silvia", "Serrano@domain.com", new DateTime(2022, 03, 02), 4, 60000, false),
            new Empleado(29, "Gabriel", "Lorenzo@correo.com", new DateTime(2023, 02, 06), 3, 45000, true),
            new Empleado(30, "Carla", "Cabrera@mail.com", new DateTime(2020, 11, 13), 4, 50000, false),
            new Empleado(31, "Fernando", "Leal@domain.com", new DateTime(2021, 05, 21), 3, 45000, false),
            new Empleado(32, "Irene", "Santos@correo.com", new DateTime(2022, 09, 19), 5, 80000, true),
            new Empleado(33, "Adrian", "Dominguez@mail.com", new DateTime(2023, 03, 27), 4, 60000, false),
            new Empleado(34, "Nuria", "Mendoza@domain.com", new DateTime(2021, 07, 29), 3, 45000, true),
            new Empleado(35, "Antonio", "Guerrero@correo.com", new DateTime(2022, 12, 15), 4, 50000, false),
            new Empleado(36, "Marta", "Espinosa@mail.com", new DateTime(2023, 05, 01), 3, 45000, false),
            new Empleado(37, "Ricardo", "Suarez@domain.com", new DateTime(2021, 09, 24), 5, 75000, true),
            new Empleado(38, "Elisa", "Reyes@correo.com", new DateTime(2020, 10, 10), 4, 60000, false),
            new Empleado(39, "Alvaro", "Aguilar@mail.com", new DateTime(2021, 08, 17), 3, 45000, true),
            new Empleado(40, "Isabel", "Paredes@domain.com", new DateTime(2023, 04, 28), 4, 50000, false),
            new Empleado(41, "Mario", "Campos@correo.com", new DateTime(2022, 11, 05), 3, 45000, false),
            new Empleado(42, "Teresa", "Muñoz@mail.com", new DateTime(2020, 06, 03), 5, 80000, true),
            new Empleado(43, "Jose", "Carrasco@domain.com", new DateTime(2021, 10, 06), 4, 60000, false),
            new Empleado(44, "Patricia", "Rivas@correo.com", new DateTime(2023, 07, 31), 3, 45000, true),
            new Empleado(45, "Luis", "Llamas@mail.com", new DateTime(2022, 01, 19), 4, 60000, false),
            new Empleado(46, "Angela", "Lozano@domain.com", new DateTime(2021, 02, 11), 3, 45000, true),
            new Empleado(47, "Hector", "Pascual@correo.com", new DateTime(2023, 06, 12), 4, 50000, false),
            new Empleado(48, "Lucia", "Herrero@mail.com", new DateTime(2022, 04, 23), 3, 45000, true),
            new Empleado(49, "Tomas", "Esteban@domain.com", new DateTime(2020, 07, 16), 5, 80000, false),
            new Empleado(50, "Monica", "Cortes@correo.com", new DateTime(2023, 08, 14), 4, 60000, true)
        };
    }
}
