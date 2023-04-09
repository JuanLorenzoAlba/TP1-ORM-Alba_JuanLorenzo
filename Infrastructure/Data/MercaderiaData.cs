using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MercaderiaData : IEntityTypeConfiguration<Mercaderia>
    {
        public void Configure(EntityTypeBuilder<Mercaderia> entityBuilder)
        {
            entityBuilder.HasData
            (
                new Mercaderia
                {
                    MercaderiaId = 1,
                    Nombre = "Empanadas de Carne",
                    Precio = 0,
                    Ingredientes = "2 tazas de harina de trigo\r\n1 cucharadita de sal\r\n1/2 taza de agua tibia\r\n1/4 taza de aceite de oliva\r\n1 cebolla picada\r\n2 dientes de ajo picados\r\n1/2 kilo de carne molida\r\n1/2 cucharadita de comino\r\n1/2 cucharadita de pimentón",
                    Preparacion = "En un bol grande, mezcla la harina y la sal. Agrega el agua tibia y el aceite de oliva. Amasa hasta que quede una masa suave y homogénea.\r\nCubre la masa con un paño y déjala reposar durante 30 minutos.\r\nPrecalienta el horno a 200°C.",
                    Imagen = "Png",
                    TipoMercaderiaId = 1
                },

                new Mercaderia
                {
                    MercaderiaId = 2,
                    Nombre = "Rollitos de primavera",
                    Precio = 0,
                    Ingredientes = "8 láminas de papel de arroz\r\n150 gramos de fideos de arroz\r\n1 zanahoria rallada\r\n1/2 pepino rallado\r\n1/4 taza de cilantro fresco picado\r\n8 hojas de lechuga\r\n8 hojas de menta fresca\r\n1 cucharada de salsa de soja",
                    Preparacion = "Coloca los fideos de arroz en un recipiente y cúbrelos con agua caliente. Déjalos reposar durante 10-15 minutos o hasta que estén blandos. Escúrrelos y reserva",
                    Imagen = "Png",
                    TipoMercaderiaId = 1
                },

                new Mercaderia
                {
                    MercaderiaId = 3,
                    Nombre = "Pollo al Curry",
                    Precio = 0,
                    Ingredientes = "4 pechugas de pollo sin piel, cortadas en cubos\r\n1 cebolla picada\r\n3 dientes de ajo picados\r\n2 cucharadas de jengibre fresco rallado\r\n2 cucharadas de curry en polvo\r\n1 lata de leche de coco\r\n1/2 taza de caldo de pollo\r\n1 pimiento rojo picado",
                    Preparacion = "En una olla o sartén grande, calienta el aceite de oliva a fuego medio. Agrega la cebolla y cocina hasta que esté suave y translúcida, unos 5 minutos.\r\nAgrega el ajo, el jengibre y el curry en polvo y cocina por un minuto, hasta que estén fragantes",
                    Imagen = "Png",
                    TipoMercaderiaId = 2
                },

                new Mercaderia
                {
                    MercaderiaId = 4,
                    Nombre = "Milanesa Napolitana",
                    Precio = 0,
                    Ingredientes = "4 filetes de carne (puedes usar carne de res, pollo o ternera)\r\n2 huevos batidos\r\n1 taza de pan rallado\r\nSal y pimienta al gusto\r\nAceite vegetal para freír\r\n4 rebanadas de jamón\r\n4 rebanadas de queso mozzarella\r\n1 taza de salsa de tomate",
                    Preparacion = "Prepara los filetes de carne: aplana cada uno con un mazo de carne o con un rodillo, hasta que tengan un grosor de aproximadamente 1 cm. Sazónalos con sal y pimienta al gusto",
                    Imagen = "Png",
                    TipoMercaderiaId = 2
                },

                new Mercaderia
                {
                    MercaderiaId = 5,
                    Nombre = "Canelones de Verdura",
                    Precio = 0,
                    Ingredientes = "12-15 placas de canelones\r\n1 calabacín mediano\r\n1 berenjena mediana\r\n2 zanahorias medianas\r\n1 cebolla mediana\r\n2 dientes de ajo picados\r\n1 taza de espinacas frescas\r\n2 tazas de salsa de tomate\r\n1 taza de queso ricotta",
                    Preparacion = "Precalienta el horno a 180°C.\r\nCocina las placas de canelones según las instrucciones del paquete, hasta que estén al dente. Escúrrelas y enjuágalas con agua fría para detener la cocción. Reserva",
                    Imagen = "Png",
                    TipoMercaderiaId = 3
                },

                new Mercaderia
                {
                    MercaderiaId = 6,
                    Nombre = "Sorrentinos de Jamon y Queso",
                    Precio = 0,
                    Ingredientes = "1 paquete de sorrentinos de jamón y queso (puedes encontrarlos en la sección de congelados)\r\n2 cucharadas de aceite de oliva\r\n1 cebolla picada finamente\r\n2 dientes de ajo picados finamente\r\n1/2 taza de caldo de pollo",
                    Preparacion = "Cocina los sorrentinos en agua hirviendo con sal durante el tiempo recomendado en el paquete, hasta que estén al dente. Escúrrelos y resérvalos.\r\nCalienta el aceite de oliva en una sartén a fuego medio",
                    Imagen = "Png",
                    TipoMercaderiaId = 3
                },

                new Mercaderia
                {
                    MercaderiaId = 7,
                    Nombre = "Bife de chorizo",
                    Precio = 0,
                    Ingredientes = "4 bifes de chorizo de 250 gramos cada uno\r\nSal gruesa\r\nPimienta negra molida\r\nAceite de oliva",
                    Preparacion = "Retira los bifes de chorizo de la nevera y deja que se pongan a temperatura ambiente durante 30 minutos antes de cocinarlos.\r\n\r\nPrecalienta la parrilla a fuego alto y cepilla la parrilla con aceite de oliva para evitar que la carne se pegue",
                    Imagen = "Png",
                    TipoMercaderiaId = 4
                },

                new Mercaderia
                {
                    MercaderiaId = 8,
                    Nombre = "Asado",
                    Precio = 0,
                    Ingredientes = "1 kilo de carne de asado (puede ser bife de chorizo, vacío, entraña, costillar, o el corte de tu preferencia)\r\nSal gruesa\r\nChimichurri (opcional)",
                    Preparacion = "Retira la carne de la nevera y deja que se ponga a temperatura ambiente durante 30-45 minutos antes de cocinarla.\r\n\r\nPrepara la parrilla y asegúrate de que las brasas estén calientes.\r\n\r\nEspolvorea la carne con sal gruesa",
                    Imagen = "Png",
                    TipoMercaderiaId = 4
                },

                new Mercaderia
                {
                    MercaderiaId = 9,
                    Nombre = "Pizza Margarita",
                    Precio = 0,
                    Ingredientes = "Masa de pizza (puedes hacerla casera o comprarla lista)\r\n1 taza de salsa de tomate\r\n250 gramos de mozzarella fresca\r\n10 hojas de albahaca fresca\r\nAceite de oliva\r\nSal y pimienta al gusto",
                    Preparacion = "Precalienta el horno a 220 grados Celsius.\r\n\r\nExtiende la masa de pizza sobre una bandeja para horno. Si la masa es casera, asegúrate de hornearla ligeramente antes de agregar los ingredientes, esto ayudará a que quede crujiente",
                    Imagen = "Png",
                    TipoMercaderiaId = 5
                },

                new Mercaderia
                {
                    MercaderiaId = 10,
                    Nombre = "Pizza Cuatro Quesos",
                    Precio = 0,
                    Ingredientes = "Masa de pizza (puedes hacerla casera o comprarla lista)\r\n1 taza de salsa de tomate\r\n150 gramos de queso mozzarella rallado\r\n50 gramos de queso gorgonzola o queso azul\r\n50 gramos de queso de cabra\r\n50 gramos de queso parmesano rallado",
                    Preparacion = "Precalienta el horno a 220 grados Celsius.\r\n\r\nExtiende la masa de pizza sobre una bandeja para horno. Si la masa es casera, asegúrate de hornearla ligeramente antes de agregar los ingredientes, esto ayudará a que quede crujiente.",
                    Imagen = "Png",
                    TipoMercaderiaId = 5
                },

                new Mercaderia
                {
                    MercaderiaId = 11,
                    Nombre = "Sandwich de atún",
                    Precio = 0,
                    Ingredientes = "2 latas de atún en agua, escurrido\r\n1/4 de taza de mayonesa\r\n1/4 de taza de cebolla picada finamente\r\n2 cucharadas de jugo de limón\r\n1 cucharadita de mostaza dijon\r\n1/4 de cucharadita de sal\r\n1/4 de cucharadita de pimienta",
                    Preparacion = "En un tazón grande, mezcla el atún, la mayonesa, la cebolla, el jugo de limón, la mostaza, la sal y la pimienta.\r\n\r\nCorta los panes por la mitad y coloca una hoja de lechuga y una rodaja de tomate en cada pan",
                    Imagen = "Png",
                    TipoMercaderiaId = 6
                },

                new Mercaderia
                {
                    MercaderiaId = 12,
                    Nombre = "Panini de jamón y queso",
                    Precio = 0,
                    Ingredientes = "4 panes para panini\r\n8 rebanadas de jamón cocido\r\n8 rebanadas de queso mozzarella\r\n1/4 de taza de pesto de albahaca\r\n2 cucharadas de mantequilla derretida",
                    Preparacion = "Precalienta una sandwichera o plancha a fuego medio-alto.\r\n\r\nAbre los panes para panini y unta el pesto de albahaca en la mitad inferior de cada pan.\r\n\r\nColoca 2 rebanadas de jamón cocido y 2 rebanadas de queso mozzarella sobre el pesto",
                    Imagen = "Png",
                    TipoMercaderiaId = 6
                },

                new Mercaderia
                {
                    MercaderiaId = 13,
                    Nombre = "Ensalada César",
                    Precio = 0,
                    Ingredientes = "1 lechuga romana grande, lavada y cortada en trozos\r\n2 tazas de crutones\r\n1/2 taza de queso parmesano rallado\r\n2 pechugas de pollo, cocidas y cortadas en tiras\r\nSal y pimienta al gusto\r\nAceite de oliva\r\nAderezo César",
                    Preparacion = "En una sartén grande, calienta un poco de aceite de oliva a fuego medio. Agrega las tiras de pollo y sazona con sal y pimienta al gusto",
                    Imagen = "Png",
                    TipoMercaderiaId = 7
                },

                new Mercaderia
                {
                    MercaderiaId = 14,
                    Nombre = "Ensalada Mediterránea",
                    Precio = 0,
                    Ingredientes = "1 lechuga romana, lavada y cortada en trozos\r\n1 taza de tomates cherry, cortados por la mitad\r\n1/2 taza de aceitunas negras, sin hueso\r\n1/2 taza de pepinos, cortados en rodajas\r\n1/2 taza de queso feta, desmenuzado",
                    Preparacion = "En un tazón grande, mezcla la lechuga romana, los tomates cherry, las aceitunas negras, los pepinos, el queso feta y la cebolla roja",
                    Imagen = "Png",
                    TipoMercaderiaId = 7
                },

                new Mercaderia
                {
                    MercaderiaId = 15,
                    Nombre = "Agua fresca",
                    Precio = 0,
                    Ingredientes = "1 litro de agua\r\n4 limones grandes\r\n1/2 taza de azúcar (o al gusto)\r\nHielo al gusto",
                    Preparacion = "Exprime los limones para obtener el jugo y reserva.\r\nEn una jarra grande, mezcla el agua y el azúcar hasta que el azúcar se disuelva por completo.\r\nAgrega el jugo de limón a la jarra y mezcla bien",
                    Imagen = "Png",
                    TipoMercaderiaId = 8
                },

                new Mercaderia
                {
                    MercaderiaId = 16,
                    Nombre = "Jugo de Naranja",
                    Precio = 0,
                    Ingredientes = "4-6 naranjas maduras\r\nAzúcar o edulcorante al gusto (opcional)\r\nAgua fría (opcional)",
                    Preparacion = "Lava bien las naranjas y córtalas por la mitad.\r\nUsa un exprimidor de cítricos para exprimir las naranjas y obtener el jugo. Si no tienes un exprimidor, puedes cortar las naranjas en trozos y procesarlas en una licuadora hasta obtener un líquido",
                    Imagen = "Png",
                    TipoMercaderiaId = 8
                },

                new Mercaderia
                {
                    MercaderiaId = 17,
                    Nombre = "Galaxitra - American IPA",
                    Precio = 0,
                    Ingredientes = "4 kg de malta de cebada (pale ale)\r\n350 g de malta crystal 40L\r\n350 g de malta Vienna\r\n20 g de lúpulo Warrior (60 minutos)\r\n30 g de lúpulo Citra (20 minutos)\r\n30 g de lúpulo Galaxy (20 minutos)\r\n30 g de lúpulo Citra (5 minutos)",
                    Preparacion = "Macera las maltas en agua a 66°C durante 60 minutos.\r\n\r\nFiltra el mosto y ponlo a hervir.\r\n\r\nAñade 20 g de lúpulo Warrior al inicio de la cocción y deja hervir durante 60 minutos.\r\n\r\nA los 20 minutos, añade 30 g de lúpulo Citra",
                    Imagen = "Png",
                    TipoMercaderiaId = 9
                },

                new Mercaderia
                {
                    MercaderiaId = 18,
                    Nombre = "Flanders Red - Sour Power",
                    Precio = 0,
                    Ingredientes = "4 kg de malta Pilsner\r\n1 kg de malta Vienna\r\n500 g de malta Munich\r\n500 g de malta Crystal 40L\r\n200 g de malta Wheat\r\n500 g de azúcar belga (candi sugar)\r\n30 g de lúpulo Saaz (60 minutos)\r\n30 g de lúpulo East Kent Goldings (10 minutos)",
                    Preparacion = "Macera las maltas en agua a 66°C durante 60 minutos.\r\n\r\nFiltra el mosto y ponlo a hervir.\r\n\r\nAñade el azúcar belga y el lúpulo Saaz al inicio de la cocción y deja hervir durante 60 minutos",
                    Imagen = "Png",
                    TipoMercaderiaId = 9
                },

                new Mercaderia
                {
                    MercaderiaId = 19,
                    Nombre = "Tiramisú",
                    Precio = 0,
                    Ingredientes = "500 gramos de queso mascarpone\r\n3 huevos\r\n150 gramos de azúcar\r\n300 ml de café fuerte\r\n200 gramos de bizcochos de soletilla\r\nCacao en polvo",
                    Preparacion = "Separa las claras y las yemas de los huevos en dos tazones diferentes.\r\nAñade el azúcar a las yemas y bátelas hasta que se vuelvan pálidas y espumosas.\r\nAñade el queso mascarpone a la mezcla de yemas y azúcar y mezcla bien.",
                    Imagen = "Png",
                    TipoMercaderiaId = 10
                },

                new Mercaderia
                {
                    MercaderiaId = 20,
                    Nombre = "Flan",
                    Precio = 0,
                    Ingredientes = "1 lata de leche condensada (397 gramos)\r\n2 tazas de leche entera\r\n4 huevos\r\n1 cucharadita de esencia de vainilla\r\n1/2 taza de azúcar",
                    Preparacion = "Precalienta el horno a 180°C.\r\nEn una olla, calienta la leche condensada y la leche entera a fuego medio, removiendo constantemente, hasta que estén bien mezcladas.\r\nEn un tazón grande, bate los huevos junto con la esencia de vainilla.",
                    Imagen = "Png",
                    TipoMercaderiaId = 10
                }
            );
        }
    }
}
