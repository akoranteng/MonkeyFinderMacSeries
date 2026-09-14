using MonkeyFinder.Models;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    public List<Monkey> GetMonkeys() =>
        new()
        {
            new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Arabia",
                Image = "baboon.jpg",
                Details = "Baboons are highly social primates living in troops of up to 300 individuals."
            },
            new Monkey
            {
                Name = "Capuchin",
                Location = "Central & South America",
                Image = "capuchin.jpg",
                Details = "Capuchins are intelligent tool‑using monkeys often seen in movies."
            },
            new Monkey
            {
                Name = "bluemonkey",
                Location = "Central Africa",
                Image = "bluemonkey.jpg",
                Details = "Blue monkeys prefer forest habitats and live in female‑led groups."
            },
            new Monkey
            {
                Name = "squirrelmonkey",
                Location = "Central & South America",
                Image = "squirrelmonkey.jpg",
                Details = "Squirrel monkeys are small, agile, and travel in large troops."
            },
            new Monkey
            {
                Name = "Howler",
                Location = "South America",
                Image = "howler.jpg",
                Details = "Known for their loud calls that can be heard up to 3 miles away."
            },
            new Monkey
            {
                Name = "Spider Monkey",
                Location = "Central & South America",
                Image = "spider.jpg",
                Details = "Spider monkeys use their long limbs and tail to swing gracefully."
            },
            new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Image = "golden.jpg",
                Details = "A striking orange‑gold monkey found in the Atlantic Forest."
            },
            new Monkey
            {
                Name = "Mandrill",
                Location = "Central Africa",
                Image = "https://upload.wikimedia.org/wikipedia/commons/3/3f/Mandrill.jpg",
                Details = "Mandrills are the most colorful primates with bright facial markings."
            },
            new Monkey
            {
                Name = "Probisis",
                Location = "Borneo",
                Image = "probisis.jpg",
                Details = "Known for their large noses and excellent swimming ability."
            },
            new Monkey
            {
                Name = "Vervet Monkey",
                Location = "Eastern Africa",
                Image = "vervet.jpg",
                Details = "Vervets have distinct facial coloration and complex social behavior."
            },
            new Monkey
            {
                Name = "Gelada",
                Location = "Ethiopia",
                Image = "gelada.jpg",
                Details = "Geladas are grass‑eating primates found only in the Ethiopian highlands."
            },
            new Monkey
            {
                Name = "Colobus Monkey",
                Location = "Africa",
                Image = "colobus.jpg",
                Details = "Colobus monkeys have beautiful black‑and‑white fur and leap between trees."
            },
            new Monkey
            {
                Name = "Macaque",
                Location = "Asia",
                Image = "macaque.jpg",
                Details = "Macaques are adaptable monkeys found in forests, cities, and snowy mountains."
            },
            new Monkey
            {
                Name = "Guenon",
                Location = "Africa",
                Image = "guenon.jpg",
                Details = "Guenons are colorful monkeys with expressive facial patterns."
            },
            new Monkey
            {
                Name = "Titi Monkey",
                Location = "South America",
                Image = "titi.jpg",
                Details = "Titi monkeys form strong pair bonds and are known for duetting calls."
            },
            new Monkey
            {
                Name = "Woolly Monkey",
                Location = "Amazon Rainforest",
                Image = "wolly.jpg",
                Details = "Large, gentle monkeys that live high in the canopy."
            },
            new Monkey
            {
                Name = "Snub‑Nosed Monkey",
                Location = "China",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/2c/Snub_Nosed_Monkey.jpg",
                Details = "These rare monkeys thrive in cold mountain forests."
            },
            new Monkey
            {
                Name = "Dusky Leaf Monkey",
                Location = "Thailand & Malaysia",
                Image = "https://upload.wikimedia.org/wikipedia/commons/3/3d/Dusky_leaf_monkey.jpg",
                Details = "Known for their adorable white eye circles and gentle nature."
            },
            new Monkey
            {
                Name = "Red‑Shanked Douc",
                Location = "Vietnam",
                Image = "https://upload.wikimedia.org/wikipedia/commons/1/1f/Red_shanked_douc.jpg",
                Details = "One of the most colorful primates in the world."
            },
            new Monkey
            {
                Name = "Silvery Marmoset",
                Location = "Brazil",
                Image = "https://upload.wikimedia.org/wikipedia/commons/4/4c/Silvery_Marmoset.jpg",
                Details = "Small, curious monkeys with striking silver fur."
            }
        };
}