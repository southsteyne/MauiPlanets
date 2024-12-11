using MauiPlanets.Models;


namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the " +
                "smallest in the Solar System. In English, it is named after the " +
                "ancient Roman god Mercurius (Mercury), god of commerce and " +
                "communication, and the messenger of the gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "-",
                    "-"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a " +
                "terrestrial planet and is the closest in mass and size to its " +
                "orbital neighbour Earth. Venus has by far the densest atmosphere " +
                "of the terrestrial planets, composed mostly of carbon dioxide " +
                "with a thick, global sulfuric acid cloud cover.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/05/venus-single.png?w=2048&format=webp",
                    "-",
                    "-",
                    "-"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and " +
                "the only astronomical object known to harbor life. This is " +
                "enabled by Earth being an ocean world, the only one in the " +
                "Solar System sustaining liquid surface water. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/hubble-captures-vivid-auroras-in-jupiters-atmosphere_28000029525_o/hubble-captures-vivid-auroras-in-jupiters-atmosphere_28000029525_o~large.jpg?w=1920&h=1913&fit=clip&crop=faces%2Cfocalpoint",
                    "-",
                    "-"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "Saturn.png",
                Description = "Saturn is the sixth planet from the Sun. It is the second largest planet in the Solar System, along with having the most moons of any planet. Saturn is most famous for its complex ring system, which is made mostly of ice chunks and crystals. Its biggest moon is Titan, the only moon to possess a defined atmosphere.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA04913/PIA04913~orig.jpg?w=1016&h=1011&fit=clip&crop=faces%2Cfocalpoint",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://images-assets.nasa.gov/image/PIA05413/PIA05413~orig.jpg?w=1024&h=1024&fit=clip&crop=faces%2Cfocalpoint"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "Eighth & fathest-away",
                HeroImage = "neptune.png",
                Description = "Imagine being so good at math that you could figure out the location of a planet you had never even seen! That is what John C. Adams did in 1843 when he discovered Neptune.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA01492/PIA01492~large.jpg?w=1920&h=1917&fit=clip&crop=faces%2Cfocalpoint",
                    "https://images-assets.nasa.gov/image/PIA01142/PIA01142~orig.jpg?w=945&h=870&fit=clip&crop=faces%2Cfocalpoint",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "Small but Mighty!",
                HeroImage = "pluto.png",
                Description = "Pluto is a small, icy world located at the edge of our solar system. Once classified as the ninth planet, it is now considered a dwarf planet. With a fascinating mix of frozen surface features, including mountains, valleys, and vast plains, Pluto remains a mysterious and intriguing object of study, orbiting the Sun in an elliptical path that takes it far beyond the other planets.",
                AccentColorStart = Color.FromArgb("#73593F"),
                AccentColorEnd = Color.FromArgb("#ccaa87"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/06/color-image-of-pluto-pia20291-1.jpg?w=2048&format=webp",
                    "-",
                    "-"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The Heart of the Asteroid Belt!",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt, located between Mars and Jupiter. Classified as a dwarf planet, it is composed of rock and water ice, with evidence of past water activity on its surface. Ceres has a mysterious, icy world that may hold clues to the early solar system.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/p/i/a/2/PIA21906_detail.jpg?w=2048&format=webp&fit=clip&crop=faces%2Cfocalpoint",
                    "-",
                    "-"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The Shapeshifting Dwarf Planet!",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune in the Kuiper Belt. Known for its unusual elongated shape, caused by its rapid rotation, Haumea is composed mostly of rock and ice. It has a ring system and at least two moons, making it a fascinating and unique object in our solar system.",
                AccentColorStart = Color.FromArgb("#544C3F"),
                AccentColorEnd = Color.FromArgb("#9e8f76"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/expanse/images/1/1f/Haumea_in_Celestia.jpg/revision/latest?cb=20200206143331",
                    "-",
                    "-"
                }
            },

            new()
            {
                Name = "MakeMake",
                Subtitle = "The Mysterious Kuiper Belt Wonder!",
                HeroImage = "makemake.png",
                Description = "MakeMake is a dwarf planet located in the Kuiper Belt, beyond Neptune. It is one of the largest known objects in this distant region and is primarily composed of rock and ice. With little known about its surface, MakeMake remains a mysterious and intriguing world in our solar system.",
                AccentColorStart = Color.FromArgb("#604331"),
                AccentColorEnd = Color.FromArgb("#b08266"),
                Images = new()
                {
                    "https://www.renderhub.com/3dstudio/dwarf-planet-makemake/dwarf-planet-makemake-01.jpg",
                    "-",
                    "-"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The Distant Giant of the Outer Solar System!",
                HeroImage = "eris.png",
                Description = "Eris is a dwarf planet located in the outermost reaches of our solar system, in the scattered disk region. Slightly smaller than Pluto, Eris is composed mostly of ice and rock, with a surface that appears reddish in color. Its discovery in 2005 reshaped our understanding of the outer solar system, and it has one known moon, Dysnomia.",
                AccentColorStart = Color.FromArgb("#666666"),
                AccentColorEnd = Color.FromArgb("#b3b3b3"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/3256/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun.jpeg?w=2048&format=webp&fit=clip&crop=faces%2Cfocalpoint",
                    "-",
                    "-"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
