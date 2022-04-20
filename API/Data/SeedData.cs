using API.Models;

namespace API.Data;

public static class SeedData
{
    public static void SeedInitalData(StudentContext context)
    {
        if (context.students.Count() > 0) return;
        List<Student> students = new List<Student>
        {
    new Student
    {
        FirstName = "Ryan",
        LastName = "Joshua",
        Location = "Leicester"
    },
    new Student
    {
        FirstName = "Shea",
        LastName = "Cleo",
        Location = "Dublin"
    },
    new Student
    {
        FirstName = "Peter",
        LastName = "Lucas",
        Location = "Giyani"
    },
    new Student
    {
        FirstName = "Pascale",
        LastName = "Desirae",
        Location = "Manaure"
    },
    new Student
    {
        FirstName = "Chaney",
        LastName = "Iola",
        Location = "Täby"
    },
    new Student
    {
        FirstName = "Aline",
        LastName = "Clinton",
        Location = "Puerto Carreño"
    },
    new Student
    {
        FirstName = "Olga",
        LastName = "Maxine",
        Location = "Gwangyang"
    },
    new Student
    {
        FirstName = "Emily",
        LastName = "Ivan",
        Location = "Vĩnh Trụ"
    },
    new Student
    {
        FirstName = "Colorado",
        LastName = "Madonna",
        Location = "Arendal"
    },
    new Student
    {
        FirstName = "Fuller",
        LastName = "Tashya",
        Location = "Mamuju"
    },
    new Student
    {
        FirstName = "Dorothy",
        LastName = "Emi",
        Location = "Motueka"
    },
    new Student
    {
        FirstName = "Eugenia",
        LastName = "Channing",
        Location = "Waitara"
    },
    new Student
    {
        FirstName = "Colby",
        LastName = "Ivan",
        Location = "Grembergen"
    },
    new Student
    {
        FirstName = "Brooke",
        LastName = "Naomi",
        Location = "Salem"
    },
    new Student
    {
        FirstName = "Macaulay",
        LastName = "Hashim",
        Location = "Villahermosa"
    },
    new Student
    {
        FirstName = "Giacomo",
        LastName = "Shad",
        Location = "Galway"
    },
    new Student
    {
        FirstName = "Ila",
        LastName = "James",
        Location = "Essene"
    },
    new Student
    {
        FirstName = "Jin",
        LastName = "Ezra",
        Location = "Đồng Xoài"
    },
    new Student
    {
        FirstName = "Wesley",
        LastName = "Kylie",
        Location = "Campagna"
    },
    new Student
    {
        FirstName = "Yeo",
        LastName = "Camille",
        Location = "Culemborg"
    },
    new Student
    {
        FirstName = "Odysseus",
        LastName = "Quon",
        Location = "Flin Flon"
    },
    new Student
    {
        FirstName = "Griffin",
        LastName = "Rhiannon",
        Location = "Reims"
    },
    new Student
    {
        FirstName = "Hayley",
        LastName = "Ian",
        Location = "Murree"
    },
    new Student
    {
        FirstName = "Pamela",
        LastName = "Reese",
        Location = "Oslo"
    },
    new Student
    {
        FirstName = "Darius",
        LastName = "Patricia",
        Location = "Feldkirch"
    },
    new Student
    {
        FirstName = "Indira",
        LastName = "Dai",
        Location = "Sloviansk"
    },
    new Student
    {
        FirstName = "Constance",
        LastName = "Oprah",
        Location = "Linköping"
    },
    new Student
    {
        FirstName = "John",
        LastName = "Marah",
        Location = "Watson Lake"
    },
    new Student
    {
        FirstName = "Jamalia",
        LastName = "Uriah",
        Location = "Arequipa"
    },
    new Student
    {
        FirstName = "Tasha",
        LastName = "Ava",
        Location = "Motueka"
    },
    new Student
    {
        FirstName = "Armand",
        LastName = "Ali",
        Location = "Akron"
    },
    new Student
    {
        FirstName = "Jerome",
        LastName = "Jessamine",
        Location = "Hohen Neuendorf"
    },
    new Student
    {
        FirstName = "Harlan",
        LastName = "Lawrence",
        Location = "Heredia"
    },
    new Student
    {
        FirstName = "Illana",
        LastName = "Hayley",
        Location = "Thái Nguyên"
    },
    new Student
    {
        FirstName = "Lacey",
        LastName = "Sydney",
        Location = "Velden am Wörther See"
    },
    new Student
    {
        FirstName = "Elliott",
        LastName = "Lysandra",
        Location = "Sakhalin"
    },
    new Student
    {
        FirstName = "Zephania",
        LastName = "Stephanie",
        Location = "Harlingen"
    },
    new Student
    {
        FirstName = "Baxter",
        LastName = "Talon",
        Location = "Chernihiv"
    },
    new Student
    {
        FirstName = "Hermione",
        LastName = "Zachary",
        Location = "Liaoning"
    },
    new Student
    {
        FirstName = "Acton",
        LastName = "Tad",
        Location = "Villahermosa"
    },
    new Student
    {
        FirstName = "Quinn",
        LastName = "Leigh",
        Location = "Parndorf"
    },
    new Student
    {
        FirstName = "Jaquelyn",
        LastName = "Maris",
        Location = "Nelson"
    },
    new Student
    {
        FirstName = "Daryl",
        LastName = "Tamara",
        Location = "Mahikeng"
    },
    new Student
    {
        FirstName = "Emerald",
        LastName = "Logan",
        Location = "Bogotá"
    },
    new Student
    {
        FirstName = "Harrison",
        LastName = "Shannon",
        Location = "Angoulême"
    },
    new Student
    {
        FirstName = "Bradley",
        LastName = "Amelia",
        Location = "Karapınar"
    },
    new Student
    {
        FirstName = "Stacey",
        LastName = "Eagan",
        Location = "East Linton"
    },
    new Student
    {
        FirstName = "Raja",
        LastName = "Dennis",
        Location = "Arequipa"
    },
    new Student
    {
        FirstName = "Linda",
        LastName = "Paul",
        Location = "Tromsø"
    },
    new Student
    {
        FirstName = "Galena",
        LastName = "Caryn",
        Location = "Levanger"
    },
    new Student
    {
        FirstName = "Genevieve",
        LastName = "Bruno",
        Location = "Joliet"
    },
    new Student
    {
        FirstName = "Whitney",
        LastName = "Robert",
        Location = "Boorsem"
    },
    new Student
    {
        FirstName = "Rashad",
        LastName = "Silas",
        Location = "Bến Tre"
    },
    new Student
    {
        FirstName = "Autumn",
        LastName = "Yasir",
        Location = "Yekaterinburg"
    },
    new Student
    {
        FirstName = "Charissa",
        LastName = "Mariam",
        Location = "Piracicaba"
    },
    new Student
    {
        FirstName = "Jonas",
        LastName = "Summer",
        Location = "Zwolle"
    },
    new Student
    {
        FirstName = "Calvin",
        LastName = "Jason",
        Location = "Dokkum"
    },
    new Student
    {
        FirstName = "Halee",
        LastName = "Barclay",
        Location = "Pizzoferrato"
    },
    new Student
    {
        FirstName = "Barbara",
        LastName = "Amal",
        Location = "Napier"
    },
    new Student
    {
        FirstName = "Leandra",
        LastName = "April",
        Location = "Kyiv"
    },
    new Student
    {
        FirstName = "Nita",
        LastName = "Myra",
        Location = "Jilin"
    },
    new Student
    {
        FirstName = "Flynn",
        LastName = "Rahim",
        Location = "Khyber Agency"
    },
    new Student
    {
        FirstName = "Lewis",
        LastName = "Isabella",
        Location = "Devonport"
    },
    new Student
    {
        FirstName = "Angelica",
        LastName = "Uma",
        Location = "Dokkum"
    },
    new Student
    {
        FirstName = "Lacey",
        LastName = "Cairo",
        Location = "Mansehra"
    },
    new Student
    {
        FirstName = "Virginia",
        LastName = "Walker",
        Location = "Chervonohrad"
    },
    new Student
    {
        FirstName = "Octavius",
        LastName = "Murphy",
        Location = "Hunan"
    },
    new Student
    {
        FirstName = "Vernon",
        LastName = "Linus",
        Location = "Prince George"
    },
    new Student
    {
        FirstName = "Reed",
        LastName = "Harriet",
        Location = "Fort Worth"
    },
    new Student
    {
        FirstName = "Venus",
        LastName = "Pandora",
        Location = "Tyumen"
    },
    new Student
    {
        FirstName = "Xanthus",
        LastName = "Kane",
        Location = "Beert"
    },
    new Student
    {
        FirstName = "Walter",
        LastName = "Fiona",
        Location = "Sankt Johann im Pongau"
    },
    new Student
    {
        FirstName = "Stone",
        LastName = "Dolan",
        Location = "Choa Chu Kang"
    },
    new Student
    {
        FirstName = "Thaddeus",
        LastName = "Talon",
        Location = "San Rafael"
    },
    new Student
    {
        FirstName = "Deanna",
        LastName = "Rosalyn",
        Location = "Sint-Joost-ten-Node"
    },
    new Student
    {
        FirstName = "Lois",
        LastName = "Drew",
        Location = "Reyhanlı"
    },
    new Student
    {
        FirstName = "Lara",
        LastName = "Kelly",
        Location = "Berdiansk"
    },
    new Student
    {
        FirstName = "Hadassah",
        LastName = "Graham",
        Location = "Cork"
    },
    new Student
    {
        FirstName = "Evan",
        LastName = "Ebony",
        Location = "Tomsk"
    },
    new Student
    {
        FirstName = "Cody",
        LastName = "Deborah",
        Location = "Voitsberg"
    },
    new Student
    {
        FirstName = "Carter",
        LastName = "Juliet",
        Location = "Erlangen"
    },
    new Student
    {
        FirstName = "Kelly",
        LastName = "Paloma",
        Location = "Bajaur Agency"
    },
    new Student
    {
        FirstName = "Zena",
        LastName = "Jeremy",
        Location = "Pontevedra"
    },
    new Student
    {
        FirstName = "Hedda",
        LastName = "Maisie",
        Location = "Saarlouis"
    },
    new Student
    {
        FirstName = "Dale",
        LastName = "Ishmael",
        Location = "Sloten"
    },
    new Student
    {
        FirstName = "Ulysses",
        LastName = "Kiara",
        Location = "Thame"
    },
    new Student
    {
        FirstName = "Salvador",
        LastName = "Griffith",
        Location = "Olinda"
    },
    new Student
    {
        FirstName = "Byron",
        LastName = "Judith",
        Location = "Toruń"
    },
    new Student
    {
        FirstName = "Kuame",
        LastName = "Megan",
        Location = "Haveli"
    },
    new Student
    {
        FirstName = "Lev",
        LastName = "Dora",
        Location = "Salvador"
    },
    new Student
    {
        FirstName = "Timothy",
        LastName = "Dorothy",
        Location = "Mexicali"
    },
    new Student
    {
        FirstName = "Gray",
        LastName = "Jennifer",
        Location = "Rankweil"
    },
    new Student
    {
        FirstName = "Ann",
        LastName = "Bradley",
        Location = "Ivano-Frankivsk"
    },
    new Student
    {
        FirstName = "Josiah",
        LastName = "Lane",
        Location = "Kristiansand"
    },
    new Student
    {
        FirstName = "Macon",
        LastName = "Ronan",
        Location = "Mandi Burewala"
    },
    new Student
    {
        FirstName = "Melvin",
        LastName = "Emily",
        Location = "Tucson"
    },
    new Student
    {
        FirstName = "Macon",
        LastName = "Ray",
        Location = "Flekkefjord"
    },
    new Student
    {
        FirstName = "Blaze",
        LastName = "Rana",
        Location = "Denver"
    },
    new Student
    {
        FirstName = "Ahmed",
        LastName = "Xantha",
        Location = "Develi"
    },
    new Student
    {
        FirstName = "Jescie",
        LastName = "Rhoda",
        Location = "Boca del Río"
    }

        };

        foreach (var student in students)
        {
            context.students.Add(student);
        }

        context.SaveChanges();

    }


}