using Footbally_Common.Enums.Player;
using Footbally_Domain.Entities.PlayerEntity.Entity;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Footbally_Infrastructure.ModelConfiguration;

public class PlayerModelBuilderConfiguration : BaseModelConfiguration<Player>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Player> builder)
    {
        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.ShirtNumber)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(m => m.Position)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(25);

        builder.Property(m => m.Age)
            .IsRequired()
            .HasDefaultValue(14);

        builder.HasMany(m => m.Goals)
            .WithOne(p => p.GoalPlayer)
            .HasForeignKey(x => x.GoalPlayerId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(m => m.Assists)
            .WithOne(p => p.AssistPlayer)
            .HasForeignKey(x => x.AssistPlayerId)
            .OnDelete(DeleteBehavior.NoAction);



        builder.HasData(
    new
    {
        Id = 1,
        FirstName = "Emiliano",
        LastName = "Martinez",
        ShirtNumber = "23",
        Position = PositionEnum.GoalKeeper,
        Age = 33,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 2,
        FirstName = "Geronimo",
        LastName = "Rulli",
        ShirtNumber = "12",
        Position = PositionEnum.GoalKeeper,
        Age = 34,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 3,
        FirstName = "Juan",
        LastName = "Musso",
        ShirtNumber = "1",
        Position = PositionEnum.GoalKeeper,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 4,
        FirstName = "Cristian",
        LastName = "Romero",
        ShirtNumber = "13",
        Position = PositionEnum.CenterBack,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 5,
        FirstName = "Nicolas",
        LastName = "Otamendi",
        ShirtNumber = "19",
        Position = PositionEnum.CenterBack,
        Age = 38,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 6,
        FirstName = "Lisandro",
        LastName = "Martinez",
        ShirtNumber = "25",
        Position = PositionEnum.CenterBack,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 7,
        FirstName = "Facundo",
        LastName = "Medina",
        ShirtNumber = "6",
        Position = PositionEnum.LeftBack,
        Age = 27,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 8,
        FirstName = "Nicolas",
        LastName = "Tagliafico",
        ShirtNumber = "3",
        Position = PositionEnum.LeftBack,
        Age = 33,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 9,
        FirstName = "Gonzalo",
        LastName = "Montiel",
        ShirtNumber = "4",
        Position = PositionEnum.RightBAck,
        Age = 29,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 10,
        FirstName = "Nahuel",
        LastName = "Molina",
        ShirtNumber = "16",
        Position = PositionEnum.RightBAck,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 11,
        FirstName = "Rodrigo",
        LastName = "De Paul",
        ShirtNumber = "7",
        Position = PositionEnum.CenterMidfilder,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 12,
        FirstName = "Enzo",
        LastName = "Fernandez",
        ShirtNumber = "8",
        Position = PositionEnum.CenterMidfilder,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 13,
        FirstName = "Alexis",
        LastName = "Mac Allister",
        ShirtNumber = "20",
        Position = PositionEnum.CenterMidfilder,
        Age = 27,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 14,
        FirstName = "Leandro",
        LastName = "Paredes",
        ShirtNumber = "5",
        Position = PositionEnum.DefendCenterMidfilder,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 15,
        FirstName = "Giovani",
        LastName = "Lo Celso",
        ShirtNumber = "18",
        Position = PositionEnum.AttackingMidfilder,
        Age = 30,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 16,
        FirstName = "Exequiel",
        LastName = "Palacios",
        ShirtNumber = "14",
        Position = PositionEnum.CenterMidfilder,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 17,
        FirstName = "Valentin",
        LastName = "Barco",
        ShirtNumber = "21",
        Position = PositionEnum.LeftWinger,
        Age = 22,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 18,
        FirstName = "Lionel",
        LastName = "Messi",
        ShirtNumber = "10",
        Position = PositionEnum.RightWinger,
        Age = 39,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 19,
        FirstName = "Julian",
        LastName = "Alvarez",
        ShirtNumber = "9",
        Position = PositionEnum.CenterForward,
        Age = 26,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 20,
        FirstName = "Lautaro",
        LastName = "Martinez",
        ShirtNumber = "22",
        Position = PositionEnum.CenterForward,
        Age = 29,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 21,
        FirstName = "Thiago",
        LastName = "Almada",
        ShirtNumber = "11",
        Position = PositionEnum.AttackingMidfilder,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 22,
        FirstName = "Nico",
        LastName = "Gonzalez",
        ShirtNumber = "15",
        Position = PositionEnum.LeftWinger,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 23,
        FirstName = "Nico",
        LastName = "Paz",
        ShirtNumber = "17",
        Position = PositionEnum.AttackingMidfilder,
        Age = 21,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 24,
        FirstName = "Giuliano",
        LastName = "Simeone",
        ShirtNumber = "24",
        Position = PositionEnum.RightWinger,
        Age = 24,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    },
    new
    {
        Id = 25,
        FirstName = "Jose Manuel",
        LastName = "Lopez",
        ShirtNumber = "26",
        Position = PositionEnum.CenterForward,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 1
    }
);

        builder.HasData(
    new
    {
        Id = 26,
        FirstName = "Alisson",
        LastName = "Becker",
        ShirtNumber = "1",
        Position = PositionEnum.GoalKeeper,
        Age = 33,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 27,
        FirstName = "Ederson",
        LastName = "Moraes",
        ShirtNumber = "23",
        Position = PositionEnum.GoalKeeper,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 28,
        FirstName = "Weverton",
        LastName = "Pereira",
        ShirtNumber = "12",
        Position = PositionEnum.GoalKeeper,
        Age = 38,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 29,
        FirstName = "Marcos",
        LastName = "Correa",
        ShirtNumber = "4",
        Position = PositionEnum.CenterBack,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 30,
        FirstName = "Gabriel",
        LastName = "Magalhaes",
        ShirtNumber = "3",
        Position = PositionEnum.CenterBack,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 31,
        FirstName = "Gleison",
        LastName = "Bremer",
        ShirtNumber = "14",
        Position = PositionEnum.CenterBack,
        Age = 29,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 32,
        FirstName = "Roger",
        LastName = "Ibanez",
        ShirtNumber = "15",
        Position = PositionEnum.CenterBack,
        Age = 27,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 33,
        FirstName = "Alex",
        LastName = "Sandro",
        ShirtNumber = "6",
        Position = PositionEnum.LeftBack,
        Age = 35,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 34,
        FirstName = "Douglas",
        LastName = "Santos",
        ShirtNumber = "16",
        Position = PositionEnum.LeftBack,
        Age = 31,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 35,
        FirstName = "Danilo",
        LastName = "Luiz",
        ShirtNumber = "2",
        Position = PositionEnum.RightBAck,
        Age = 34,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 36,
        FirstName = "Wesley",
        LastName = "Franca",
        ShirtNumber = "13",
        Position = PositionEnum.RightBAck,
        Age = 22,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 37,
        FirstName = "Casemiro",
        LastName = "Santos",
        ShirtNumber = "5",
        Position = PositionEnum.DefendCenterMidfilder,
        Age = 34,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 38,
        FirstName = "Bruno",
        LastName = "Guimaraes",
        ShirtNumber = "8",
        Position = PositionEnum.CenterMidfilder,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 39,
        FirstName = "Fabinho",
        LastName = "Tavares",
        ShirtNumber = "15",
        Position = PositionEnum.DefendCenterMidfilder,
        Age = 32,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 40,
        FirstName = "Lucas",
        LastName = "Paqueta",
        ShirtNumber = "10",
        Position = PositionEnum.AttackingMidfilder,
        Age = 28,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 41,
        FirstName = "Danilo",
        LastName = "Santos",
        ShirtNumber = "17",
        Position = PositionEnum.CenterMidfilder,
        Age = 24,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 42,
        FirstName = "Vinicius",
        LastName = "Junior",
        ShirtNumber = "7",
        Position = PositionEnum.LeftWinger,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 43,
        FirstName = "Raphinha",
        LastName = "Belloli",
        ShirtNumber = "11",
        Position = PositionEnum.RightWinger,
        Age = 29,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 44,
        FirstName = "Neymar",
        LastName = "Junior",
        ShirtNumber = "10",
        Position = PositionEnum.AttackingMidfilder,
        Age = 34,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 45,
        FirstName = "Gabriel",
        LastName = "Martinelli",
        ShirtNumber = "20",
        Position = PositionEnum.LeftWinger,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 46,
        FirstName = "Matheus",
        LastName = "Cunha",
        ShirtNumber = "21",
        Position = PositionEnum.CenterForward,
        Age = 27,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 47,
        FirstName = "Endrick",
        LastName = "Felipe",
        ShirtNumber = "9",
        Position = PositionEnum.CenterForward,
        Age = 19,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 48,
        FirstName = "Igor",
        LastName = "Thiago",
        ShirtNumber = "19",
        Position = PositionEnum.CenterForward,
        Age = 24,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 49,
        FirstName = "Luiz",
        LastName = "Henrique",
        ShirtNumber = "22",
        Position = PositionEnum.RightWinger,
        Age = 25,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    },
    new
    {
        Id = 50,
        FirstName = "Rayan",
        LastName = "Vitor",
        ShirtNumber = "24",
        Position = PositionEnum.RightWinger,
        Age = 19,
        Goals = 0,
        Assist = 0,
        TeamId = 2
    }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 51, FirstName = "Jordan", LastName = "Pickford", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 52, FirstName = "Dean", LastName = "Henderson", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 53, FirstName = "James", LastName = "Trafford", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 3 },

    // Defenders
    new { Id = 54, FirstName = "Dan", LastName = "Burn", ShirtNumber = "14", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 55, FirstName = "Marc", LastName = "Guehi", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 56, FirstName = "Reece", LastName = "James", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 57, FirstName = "Ezri", LastName = "Konsa", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 58, FirstName = "Tino", LastName = "Livramento", ShirtNumber = "21", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 59, FirstName = "Nico", LastName = "OReilly", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 21, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 60, FirstName = "Jarell", LastName = "Quansah", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 61, FirstName = "Djed", LastName = "Spence", ShirtNumber = "12", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 62, FirstName = "John", LastName = "Stones", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 3 },

    // Midfielders
    new { Id = 63, FirstName = "Elliot", LastName = "Anderson", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 64, FirstName = "Jude", LastName = "Bellingham", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 65, FirstName = "Eberechi", LastName = "Eze", ShirtNumber = "18", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 66, FirstName = "Jordan", LastName = "Henderson", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 36, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 67, FirstName = "Kobbie", LastName = "Mainoo", ShirtNumber = "26", Position = PositionEnum.CenterMidfilder, Age = 21, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 68, FirstName = "Declan", LastName = "Rice", ShirtNumber = "7", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 69, FirstName = "Morgan", LastName = "Rogers", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 3 },

    // Forwards
    new { Id = 70, FirstName = "Anthony", LastName = "Gordon", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 71, FirstName = "Harry", LastName = "Kane", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 72, FirstName = "Noni", LastName = "Madueke", ShirtNumber = "20", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 73, FirstName = "Marcus", LastName = "Rashford", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 74, FirstName = "Bukayo", LastName = "Saka", ShirtNumber = "25", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 75, FirstName = "Ivan", LastName = "Toney", ShirtNumber = "22", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 3 },
    new { Id = 76, FirstName = "Ollie", LastName = "Watkins", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 3 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 77, FirstName = "Mike", LastName = "Maignan", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 78, FirstName = "Brice", LastName = "Samba", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 79, FirstName = "Robin", LastName = "Risser", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 21, Goals = 0, Assist = 0, TeamId = 4 },

    // Defenders
    new { Id = 80, FirstName = "Malo", LastName = "Gusto", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 23, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 81, FirstName = "Jules", LastName = "Kounde", ShirtNumber = "5", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 82, FirstName = "Lucas", LastName = "Digne", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 32, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 83, FirstName = "Theo", LastName = "Hernandez", ShirtNumber = "22", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 84, FirstName = "Lucas", LastName = "Hernandez", ShirtNumber = "21", Position = PositionEnum.LeftBack, Age = 30, Goals = 0, Assist = 0, TeamId = 4 },

    new { Id = 85, FirstName = "William", LastName = "Saliba", ShirtNumber = "17", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 86, FirstName = "Dayot", LastName = "Upamecano", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 87, FirstName = "Ibrahima", LastName = "Konate", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 88, FirstName = "Maxence", LastName = "Lacroix", ShirtNumber = "24", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 4 },

    // Midfielders
    new { Id = 89, FirstName = "Aurelien", LastName = "Tchouameni", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 90, FirstName = "Adrien", LastName = "Rabiot", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 91, FirstName = "NGolo", LastName = "Kante", ShirtNumber = "13", Position = PositionEnum.DefendCenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 92, FirstName = "Manu", LastName = "Kone", ShirtNumber = "6", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 93, FirstName = "Warren", LastName = "Zaire-Emery", ShirtNumber = "18", Position = PositionEnum.CenterMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 4 },

    // Forwards
    new { Id = 94, FirstName = "Kylian", LastName = "Mbappe", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 95, FirstName = "Ousmane", LastName = "Dembele", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 96, FirstName = "Michael", LastName = "Olise", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 97, FirstName = "Bradley", LastName = "Barcola", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 98, FirstName = "Desire", LastName = "Doue", ShirtNumber = "12", Position = PositionEnum.LeftWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 4 },

    new { Id = 99, FirstName = "Rayan", LastName = "Cherki", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 100, FirstName = "Maghnes", LastName = "Akliouche", ShirtNumber = "25", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 4 },

    new { Id = 101, FirstName = "Marcus", LastName = "Thuram", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 4 },
    new { Id = 102, FirstName = "Jean-Philippe", LastName = "Mateta", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 4 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 103, FirstName = "Manuel", LastName = "Neuer", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 40, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 104, FirstName = "Oliver", LastName = "Baumann", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 35, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 105, FirstName = "Alexander", LastName = "Nubel", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 5 },

    // Defenders
    new { Id = 106, FirstName = "Antonio", LastName = "Rudiger", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 107, FirstName = "Jonathan", LastName = "Tah", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 108, FirstName = "Nico", LastName = "Schlotterbeck", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 109, FirstName = "Waldemar", LastName = "Anton", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 110, FirstName = "Malick", LastName = "Thiaw", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 5 },

    new { Id = 111, FirstName = "Joshua", LastName = "Kimmich", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 112, FirstName = "David", LastName = "Raum", ShirtNumber = "18", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 113, FirstName = "Nathaniel", LastName = "Brown", ShirtNumber = "20", Position = PositionEnum.LeftBack, Age = 22, Goals = 0, Assist = 0, TeamId = 5 },

    // Midfielders
    new { Id = 114, FirstName = "Leon", LastName = "Goretzka", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 115, FirstName = "Aleksandar", LastName = "Pavlovic", ShirtNumber = "5", Position = PositionEnum.DefendCenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 116, FirstName = "Angelo", LastName = "Stiller", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 117, FirstName = "Pascal", LastName = "Gross", ShirtNumber = "19", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 118, FirstName = "Nadiem", LastName = "Amiri", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 119, FirstName = "Felix", LastName = "Nmecha", ShirtNumber = "13", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 5 },

    // Attacking midfield / wings
    new { Id = 120, FirstName = "Jamal", LastName = "Musiala", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 121, FirstName = "Florian", LastName = "Wirtz", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 122, FirstName = "Jamie", LastName = "Leweling", ShirtNumber = "9", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 123, FirstName = "Leroy", LastName = "Sane", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 124, FirstName = "Lennart", LastName = "Karl", ShirtNumber = "24", Position = PositionEnum.RightWinger, Age = 18, Goals = 0, Assist = 0, TeamId = 5 },

    // Forwards
    new { Id = 125, FirstName = "Kai", LastName = "Havertz", ShirtNumber = "22", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 126, FirstName = "Deniz", LastName = "Undav", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 127, FirstName = "Nick", LastName = "Woltemade", ShirtNumber = "25", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 5 },
    new { Id = 128, FirstName = "Maximilian", LastName = "Beier", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 5 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 129, FirstName = "Unai", LastName = "Simon", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 130, FirstName = "David", LastName = "Raya", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 131, FirstName = "Joan", LastName = "Garcia", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 6 },

    // Defenders
    new { Id = 132, FirstName = "Pedro", LastName = "Porro", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 133, FirstName = "Marcos", LastName = "Llorente", ShirtNumber = "14", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 134, FirstName = "Aymeric", LastName = "Laporte", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 135, FirstName = "Pau", LastName = "Cubarsi", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 19, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 136, FirstName = "Marc", LastName = "Pubill", ShirtNumber = "15", Position = PositionEnum.RightBAck, Age = 22, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 137, FirstName = "Eric", LastName = "Garcia", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 138, FirstName = "Marc", LastName = "Cucurella", ShirtNumber = "24", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 139, FirstName = "Alex", LastName = "Grimaldo", ShirtNumber = "18", Position = PositionEnum.LeftBack, Age = 30, Goals = 0, Assist = 0, TeamId = 6 },

    // Midfielders
    new { Id = 140, FirstName = "Rodri", LastName = "Hernandez", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 141, FirstName = "Martin", LastName = "Zubimendi", ShirtNumber = "16", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 142, FirstName = "Pedri", LastName = "Gonzalez", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 143, FirstName = "Fabian", LastName = "Ruiz", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 144, FirstName = "Mikel", LastName = "Merino", ShirtNumber = "5", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 145, FirstName = "Pablo", LastName = "Gavi", ShirtNumber = "9", Position = PositionEnum.AttackingMidfilder, Age = 21, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 146, FirstName = "Alex", LastName = "Baena", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 6 },

    // Forwards
    new { Id = 147, FirstName = "Mikel", LastName = "Oyarzabal", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 148, FirstName = "Lamine", LastName = "Yamal", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 18, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 149, FirstName = "Ferran", LastName = "Torres", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 150, FirstName = "Borja", LastName = "Iglesias", ShirtNumber = "22", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 151, FirstName = "Dani", LastName = "Olmo", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 152, FirstName = "Victor", LastName = "Munoz", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 153, FirstName = "Nico", LastName = "Williams", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 6 },
    new { Id = 154, FirstName = "Yeremy", LastName = "Pino", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 6 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 155, FirstName = "Diogo", LastName = "Costa", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 156, FirstName = "Rui", LastName = "Silva", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 157, FirstName = "Jose", LastName = "Sa", ShirtNumber = "22", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 7 },

    // Defenders
    new { Id = 158, FirstName = "Diogo", LastName = "Dalot", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 159, FirstName = "Joao", LastName = "Cancelo", ShirtNumber = "20", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 160, FirstName = "Nuno", LastName = "Mendes", ShirtNumber = "19", Position = PositionEnum.LeftBack, Age = 24, Goals = 0, Assist = 0, TeamId = 7 },

    new { Id = 161, FirstName = "Ruben", LastName = "Dias", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 162, FirstName = "Goncalo", LastName = "Inacio", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 163, FirstName = "Tomas", LastName = "Araujo", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 164, FirstName = "Renato", LastName = "Veiga", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 165, FirstName = "Nelson", LastName = "Semedo", ShirtNumber = "16", Position = PositionEnum.RightBAck, Age = 33, Goals = 0, Assist = 0, TeamId = 7 },

    // Midfielders
    new { Id = 166, FirstName = "Bruno", LastName = "Fernandes", ShirtNumber = "8", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 167, FirstName = "Bernardo", LastName = "Silva", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 168, FirstName = "Vitinha", LastName = "Ferreira", ShirtNumber = "23", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 169, FirstName = "Joao", LastName = "Neves", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 170, FirstName = "Ruben", LastName = "Neves", ShirtNumber = "18", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 171, FirstName = "Joao", LastName = "Palhinha", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 7 },

    // Forwards
    new { Id = 172, FirstName = "Cristiano", LastName = "Ronaldo", ShirtNumber = "7", Position = PositionEnum.CenterForward, Age = 41, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 173, FirstName = "Rafael", LastName = "Leao", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 174, FirstName = "Pedro", LastName = "Neto", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 175, FirstName = "Francisco", LastName = "Conceicao", ShirtNumber = "21", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 176, FirstName = "Joao", LastName = "Felix", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 177, FirstName = "Goncalo", LastName = "Ramos", ShirtNumber = "13", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 178, FirstName = "Francisco", LastName = "Trincao", ShirtNumber = "24", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 7 },
    new { Id = 179, FirstName = "Goncalo", LastName = "Guedes", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 7 }
);

        builder.HasData(
// Goalkeepers
// Goalkeepers
new { Id = 180, FirstName = "Thibaut", LastName = "Courtois", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 8 },

new { Id = 181, FirstName = "Senne", LastName = "Lammens", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 8 },

new { Id = 182, FirstName = "Mike", LastName = "Penders", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 20, Goals = 0, Assist = 0, TeamId = 8 },
    // Defenders
    new { Id = 183, FirstName = "Timothy", LastName = "Castagne", ShirtNumber = "21", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 184, FirstName = "Thomas", LastName = "Meunier", ShirtNumber = "15", Position = PositionEnum.RightBAck, Age = 35, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 185, FirstName = "Arthur", LastName = "Theate", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 26, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 186, FirstName = "Maxim", LastName = "De Cuyper", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 8 },

    new { Id = 187, FirstName = "Wout", LastName = "Faes", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 188, FirstName = "Zeno", LastName = "Debast", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 189, FirstName = "Koni", LastName = "De Winter", ShirtNumber = "14", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 190, FirstName = "Brandon", LastName = "Mechele", ShirtNumber = "18", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 8 },

    // Midfielders
    new { Id = 191, FirstName = "Youri", LastName = "Tielemans", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 192, FirstName = "Amadou", LastName = "Onana", ShirtNumber = "24", Position = PositionEnum.DefendCenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 193, FirstName = "Orel", LastName = "Mangala", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 194, FirstName = "Nicolas", LastName = "Raskin", ShirtNumber = "6", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 195, FirstName = "Kevin", LastName = "De Bruyne", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 8 },

    // Forwards
    new { Id = 196, FirstName = "Jeremy", LastName = "Doku", ShirtNumber = "22", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 197, FirstName = "Leandro", LastName = "Trossard", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 32, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 198, FirstName = "Johan", LastName = "Bakayoko", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 199, FirstName = "Malick", LastName = "Fofana", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 8 },

    new { Id = 200, FirstName = "Romelu", LastName = "Lukaku", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 201, FirstName = "Lois", LastName = "Openda", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 202, FirstName = "Charles", LastName = "De Ketelaere", ShirtNumber = "16", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 203, FirstName = "Dodi", LastName = "Lukebakio", ShirtNumber = "25", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 8 },
    new { Id = 204, FirstName = "Michy", LastName = "Batshuayi", ShirtNumber = "23", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 8 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 205, FirstName = "Bart", LastName = "Verbruggen", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 206, FirstName = "Mark", LastName = "Flekken", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 207, FirstName = "Robin", LastName = "Roefs", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 22, Goals = 0, Assist = 0, TeamId = 9 },

    // Defenders
    new { Id = 208, FirstName = "Virgil", LastName = "van Dijk", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 209, FirstName = "Nathan", LastName = "Ake", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 210, FirstName = "Micky", LastName = "van de Ven", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 211, FirstName = "Jan Paul", LastName = "van Hecke", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 212, FirstName = "Jorrel", LastName = "Hato", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 20, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 213, FirstName = "Jurriën", LastName = "Timber", ShirtNumber = "12", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 214, FirstName = "Denzel", LastName = "Dumfries", ShirtNumber = "22", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 9 },

    // Midfielders
    new { Id = 215, FirstName = "Frenkie", LastName = "de Jong", ShirtNumber = "21", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 216, FirstName = "Ryan", LastName = "Gravenberch", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 217, FirstName = "Tijjani", LastName = "Reijnders", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 218, FirstName = "Teun", LastName = "Koopmeiners", ShirtNumber = "6", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 219, FirstName = "Marten", LastName = "de Roon", ShirtNumber = "18", Position = PositionEnum.DefendCenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 220, FirstName = "Quinten", LastName = "Timber", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 221, FirstName = "Guus", LastName = "Til", ShirtNumber = "16", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 222, FirstName = "Mats", LastName = "Wieffer", ShirtNumber = "17", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 9 },

    // Forwards
    new { Id = 223, FirstName = "Memphis", LastName = "Depay", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 224, FirstName = "Cody", LastName = "Gakpo", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 225, FirstName = "Donyell", LastName = "Malen", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 226, FirstName = "Justin", LastName = "Kluivert", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 227, FirstName = "Noa", LastName = "Lang", ShirtNumber = "9", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 228, FirstName = "Brian", LastName = "Brobbey", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 229, FirstName = "Crysencio", LastName = "Summerville", ShirtNumber = "25", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 9 },
    new { Id = 230, FirstName = "Wout", LastName = "Weghorst", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 9 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 231, FirstName = "Dominik", LastName = "Livakovic", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 232, FirstName = "Ivor", LastName = "Pandur", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 233, FirstName = "Dominik", LastName = "Kotarski", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 10 },

    // Defenders
    new { Id = 234, FirstName = "Josip", LastName = "Stanisic", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 235, FirstName = "Marin", LastName = "Pongracic", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 236, FirstName = "Josko", LastName = "Gvardiol", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 237, FirstName = "Duje", LastName = "Caleta-Car", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 238, FirstName = "Josip", LastName = "Sutalo", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 239, FirstName = "Martin", LastName = "Erlic", ShirtNumber = "25", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 240, FirstName = "Luka", LastName = "Vuskovic", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 19, Goals = 0, Assist = 0, TeamId = 10 },

    // Midfielders
    new { Id = 241, FirstName = "Nikola", LastName = "Moro", ShirtNumber = "7", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 242, FirstName = "Mateo", LastName = "Kovacic", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 243, FirstName = "Luka", LastName = "Modric", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 40, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 244, FirstName = "Nikola", LastName = "Vlasic", ShirtNumber = "13", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 245, FirstName = "Mario", LastName = "Pasalic", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 246, FirstName = "Martin", LastName = "Baturina", ShirtNumber = "16", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 247, FirstName = "Petar", LastName = "Sucic", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 248, FirstName = "Kristijan", LastName = "Jakic", ShirtNumber = "18", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 249, FirstName = "Toni", LastName = "Fruk", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 250, FirstName = "Luka", LastName = "Sucic", ShirtNumber = "21", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 10 },

    // Forwards
    new { Id = 251, FirstName = "Andrej", LastName = "Kramaric", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 35, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 252, FirstName = "Ante", LastName = "Budimir", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 35, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 253, FirstName = "Ivan", LastName = "Perisic", ShirtNumber = "14", Position = PositionEnum.LeftWinger, Age = 37, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 254, FirstName = "Igor", LastName = "Matanovic", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 255, FirstName = "Marco", LastName = "Pasalic", ShirtNumber = "24", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 10 },
    new { Id = 256, FirstName = "Petar", LastName = "Musa", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 10 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 257, FirstName = "Gregor", LastName = "Kobel", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 258, FirstName = "Marvin", LastName = "Keller", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 259, FirstName = "Yvon", LastName = "Mvogo", ShirtNumber = "21", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 11 },

    // Defenders
    new { Id = 260, FirstName = "Manuel", LastName = "Akanji", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 261, FirstName = "Nico", LastName = "Elvedi", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 262, FirstName = "Ricardo", LastName = "Rodriguez", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 34, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 263, FirstName = "Silvan", LastName = "Widmer", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 33, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 264, FirstName = "Miro", LastName = "Muheim", ShirtNumber = "17", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 265, FirstName = "Aurele", LastName = "Amenda", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 266, FirstName = "Eray", LastName = "Comert", ShirtNumber = "18", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 267, FirstName = "Luca", LastName = "Jaquez", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 22, Goals = 0, Assist = 0, TeamId = 11 },

    // Midfielders
    new { Id = 268, FirstName = "Granit", LastName = "Xhaka", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 269, FirstName = "Denis", LastName = "Zakaria", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 270, FirstName = "Remo", LastName = "Freuler", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 271, FirstName = "Djibril", LastName = "Sow", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 272, FirstName = "Ardon", LastName = "Jashari", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 273, FirstName = "Fabian", LastName = "Rieder", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 274, FirstName = "Michel", LastName = "Aebischer", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 275, FirstName = "Christian", LastName = "Fassnacht", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 276, FirstName = "Johan", LastName = "Manzambi", ShirtNumber = "24", Position = PositionEnum.AttackingMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 11 },

    // Forwards
    new { Id = 277, FirstName = "Breel", LastName = "Embolo", ShirtNumber = "7", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 278, FirstName = "Zeki", LastName = "Amdouni", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 279, FirstName = "Dan", LastName = "Ndoye", ShirtNumber = "23", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 280, FirstName = "Noah", LastName = "Okafor", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 281, FirstName = "Ruben", LastName = "Vargas", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 11 },
    new { Id = 282, FirstName = "Cedric", LastName = "Itten", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 11 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 283, FirstName = "Alexander", LastName = "Schlager", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 284, FirstName = "Patrick", LastName = "Pentz", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 285, FirstName = "Florian", LastName = "Wiegele", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 12 },

    // Defenders
    new { Id = 286, FirstName = "David", LastName = "Alaba", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 287, FirstName = "Kevin", LastName = "Danso", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 288, FirstName = "Philipp", LastName = "Lienhart", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 289, FirstName = "Marco", LastName = "Friedl", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 290, FirstName = "David", LastName = "Affengruber", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 291, FirstName = "Michael", LastName = "Svoboda", ShirtNumber = "21", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 12 },

    new { Id = 292, FirstName = "Stefan", LastName = "Posch", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 293, FirstName = "Phillipp", LastName = "Mwene", ShirtNumber = "16", Position = PositionEnum.LeftBack, Age = 32, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 294, FirstName = "Alexander", LastName = "Prass", ShirtNumber = "17", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 12 },

    // Midfielders
    new { Id = 295, FirstName = "Konrad", LastName = "Laimer", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 296, FirstName = "Marcel", LastName = "Sabitzer", ShirtNumber = "9", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 297, FirstName = "Nicolas", LastName = "Seiwald", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 298, FirstName = "Xaver", LastName = "Schlager", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 299, FirstName = "Romano", LastName = "Schmid", ShirtNumber = "18", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 300, FirstName = "Patrick", LastName = "Wimmer", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 301, FirstName = "Paul", LastName = "Wanner", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 302, FirstName = "Carney", LastName = "Chukwuemeka", ShirtNumber = "19", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 303, FirstName = "Florian", LastName = "Grillitsch", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 304, FirstName = "Alessandro", LastName = "Schopf", ShirtNumber = "24", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 12 },

    // Forwards
    new { Id = 305, FirstName = "Marko", LastName = "Arnautovic", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 37, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 306, FirstName = "Michael", LastName = "Gregoritsch", ShirtNumber = "25", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 12 },
    new { Id = 307, FirstName = "Sasa", LastName = "Kalajdzic", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 12 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 308, FirstName = "Viktor", LastName = "Johansson", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 309, FirstName = "Kristoffer", LastName = "Nordfeldt", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 37, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 310, FirstName = "Jacob", LastName = "Zetterstrom", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 13 },

    // Defenders
    new { Id = 311, FirstName = "Victor", LastName = "Lindelof", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 312, FirstName = "Isak", LastName = "Hien", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 313, FirstName = "Carl", LastName = "Starfelt", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 314, FirstName = "Hjalmar", LastName = "Ekdal", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 315, FirstName = "Gabriel", LastName = "Gudmundsson", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 316, FirstName = "Daniel", LastName = "Svensson", ShirtNumber = "14", Position = PositionEnum.LeftBack, Age = 24, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 317, FirstName = "Gustaf", LastName = "Lagerbielke", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 318, FirstName = "Eric", LastName = "Smith", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 13 },

    // Midfielders
    new { Id = 319, FirstName = "Lucas", LastName = "Bergvall", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 320, FirstName = "Yasin", LastName = "Ayari", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 321, FirstName = "Mattias", LastName = "Svanberg", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 322, FirstName = "Jesper", LastName = "Karlstrom", ShirtNumber = "18", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 323, FirstName = "Besfort", LastName = "Zeneli", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 324, FirstName = "Benjamin", LastName = "Nygren", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 325, FirstName = "Ken", LastName = "Sema", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 13 },

    // Forwards
    new { Id = 326, FirstName = "Alexander", LastName = "Isak", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 327, FirstName = "Viktor", LastName = "Gyokeres", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 328, FirstName = "Anthony", LastName = "Elanga", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 329, FirstName = "Taha", LastName = "Ali", ShirtNumber = "21", Position = PositionEnum.RightWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 330, FirstName = "Alexander", LastName = "Bernhardsson", ShirtNumber = "22", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 331, FirstName = "Gustaf", LastName = "Nilsson", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 13 },

    // Utility players
    new { Id = 332, FirstName = "Elliot", LastName = "Stroud", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 13 },
    new { Id = 333, FirstName = "Emil", LastName = "Holm", ShirtNumber = "26", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 13 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 334, FirstName = "Orjan", LastName = "Nyland", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 35, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 335, FirstName = "Egil", LastName = "Selvik", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 336, FirstName = "Sander", LastName = "Tangvik", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 14 },

    // Defenders
    new { Id = 337, FirstName = "Kristoffer", LastName = "Ajer", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 338, FirstName = "Leo", LastName = "Ostigard", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 339, FirstName = "Julian", LastName = "Ryerson", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 28, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 340, FirstName = "Marcus", LastName = "Pedersen", ShirtNumber = "14", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 341, FirstName = "Fredrik", LastName = "Bjorkan", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 342, FirstName = "David", LastName = "Wolfe", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 24, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 343, FirstName = "Torbjorn", LastName = "Heggem", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 344, FirstName = "Sondre", LastName = "Langas", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 345, FirstName = "Henrik", LastName = "Falchener", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 14 },

    // Midfielders
    new { Id = 346, FirstName = "Martin", LastName = "Odegaard", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 347, FirstName = "Sander", LastName = "Berge", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 348, FirstName = "Patrick", LastName = "Berg", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 349, FirstName = "Fredrik", LastName = "Aursnes", ShirtNumber = "18", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 350, FirstName = "Kristian", LastName = "Thorstvedt", ShirtNumber = "20", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 351, FirstName = "Morten", LastName = "Thorsby", ShirtNumber = "19", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 352, FirstName = "Oscar", LastName = "Bobb", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 353, FirstName = "Thelo", LastName = "Aasgaard", ShirtNumber = "21", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 354, FirstName = "Andreas", LastName = "Schjelderup", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 355, FirstName = "Jens", LastName = "Hauge", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 14 },

    // Forwards
    new { Id = 356, FirstName = "Erling", LastName = "Haaland", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 357, FirstName = "Alexander", LastName = "Sorloth", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 358, FirstName = "Jorgen", LastName = "Strand Larsen", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 14 },
    new { Id = 359, FirstName = "Antonio", LastName = "Nusa", ShirtNumber = "14", Position = PositionEnum.LeftWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 14 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 360, FirstName = "Angus", LastName = "Gunn", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 361, FirstName = "Liam", LastName = "Kelly", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 362, FirstName = "Craig", LastName = "Gordon", ShirtNumber = "21", Position = PositionEnum.GoalKeeper, Age = 43, Goals = 0, Assist = 0, TeamId = 15 },

    // Defenders
    new { Id = 363, FirstName = "Aaron", LastName = "Hickey", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 364, FirstName = "Andy", LastName = "Robertson", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 32, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 365, FirstName = "Grant", LastName = "Hanley", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 366, FirstName = "Kieran", LastName = "Tierney", ShirtNumber = "6", Position = PositionEnum.LeftBack, Age = 29, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 367, FirstName = "Jack", LastName = "Hendry", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 368, FirstName = "John", LastName = "Souttar", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 369, FirstName = "Dominic", LastName = "Hyam", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 370, FirstName = "Nathan", LastName = "Patterson", ShirtNumber = "22", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 371, FirstName = "Anthony", LastName = "Ralston", ShirtNumber = "24", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 372, FirstName = "Scott", LastName = "McKenna", ShirtNumber = "26", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 15 },

    // Midfielders
    new { Id = 373, FirstName = "Scott", LastName = "McTominay", ShirtNumber = "4", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 374, FirstName = "John", LastName = "McGinn", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 375, FirstName = "Tyler", LastName = "Fletcher", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 19, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 376, FirstName = "Ryan", LastName = "Christie", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 377, FirstName = "Lewis", LastName = "Ferguson", ShirtNumber = "19", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 378, FirstName = "Kenny", LastName = "McLean", ShirtNumber = "23", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 379, FirstName = "Ben", LastName = "Doak", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 20, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 380, FirstName = "Findlay", LastName = "Curtis", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 19, Goals = 0, Assist = 0, TeamId = 15 },

    // Forwards
    new { Id = 381, FirstName = "Lyndon", LastName = "Dykes", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 382, FirstName = "Che", LastName = "Adams", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 383, FirstName = "Ross", LastName = "Stewart", ShirtNumber = "14", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 384, FirstName = "George", LastName = "Hirst", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 15 },
    new { Id = 385, FirstName = "Lawrence", LastName = "Shankland", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 15 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 386, FirstName = "Nikola", LastName = "Vasilj", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 387, FirstName = "Kenan", LastName = "Piric", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 388, FirstName = "Osman", LastName = "Hadzikic", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 16 },

    // Defenders
    new { Id = 389, FirstName = "Amar", LastName = "Dedic", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 390, FirstName = "Sead", LastName = "Kolasinac", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 391, FirstName = "Adrian", LastName = "Leon Barisic", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 392, FirstName = "Anel", LastName = "Ahmedhodzic", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 393, FirstName = "Dennis", LastName = "Hadzikadunic", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 394, FirstName = "Tarik", LastName = "Muharemovic", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 395, FirstName = "Eldar", LastName = "Civic", ShirtNumber = "18", Position = PositionEnum.LeftBack, Age = 30, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 396, FirstName = "Nihad", LastName = "Mujakic", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 16 },

    // Midfielders
    new { Id = 397, FirstName = "Benjamin", LastName = "Tahirovic", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 398, FirstName = "Amir", LastName = "Hadziahmetovic", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 399, FirstName = "Ivan", LastName = "Basic", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 400, FirstName = "Armin", LastName = "Gigovic", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 401, FirstName = "Dario", LastName = "Saric", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 402, FirstName = "Haris", LastName = "Hajradinovic", ShirtNumber = "20", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 403, FirstName = "Esmir", LastName = "Bajraktarevic", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 404, FirstName = "Ermedin", LastName = "Demirovic", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 16 },

    // Forwards
    new { Id = 405, FirstName = "Edin", LastName = "Dzeko", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 40, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 406, FirstName = "Samed", LastName = "Bazdar", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 22, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 407, FirstName = "Luka", LastName = "Kulenovic", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 408, FirstName = "Armin", LastName = "Tabakovic", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 409, FirstName = "Nail", LastName = "Omerovic", ShirtNumber = "25", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 16 },
    new { Id = 410, FirstName = "Dzenis", LastName = "Burnic", ShirtNumber = "26", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 16 }
);

        builder.HasData(

// Goalkeepers
new { Id = 412, FirstName = "Lukas", LastName = "Hornicek", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 413, FirstName = "Matej", LastName = "Kovar", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 414, FirstName = "Jindrich", LastName = "Stanek", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 17 },

// Defenders
new { Id = 415, FirstName = "Vladimir", LastName = "Coufal", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 33, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 416, FirstName = "David", LastName = "Doudera", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 28, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 417, FirstName = "Tomas", LastName = "Holes", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 418, FirstName = "Robin", LastName = "Hranac", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 419, FirstName = "Stepan", LastName = "Chaloupek", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 420, FirstName = "David", LastName = "Jurasek", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 421, FirstName = "Ladislav", LastName = "Krejci", ShirtNumber = "7", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 422, FirstName = "Jaroslav", LastName = "Zeleny", ShirtNumber = "18", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 423, FirstName = "David", LastName = "Zima", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 17 },

// Midfielders
new { Id = 424, FirstName = "Lukas", LastName = "Cerv", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 425, FirstName = "Vladimir", LastName = "Darida", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 426, FirstName = "Lukas", LastName = "Provod", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 427, FirstName = "Michal", LastName = "Sadilek", ShirtNumber = "22", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 428, FirstName = "Hugo", LastName = "Sochurek", ShirtNumber = "24", Position = PositionEnum.CenterMidfilder, Age = 17, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 429, FirstName = "Alexandr", LastName = "Sojka", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 430, FirstName = "Tomas", LastName = "Soucek", ShirtNumber = "21", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 431, FirstName = "Pavel", LastName = "Sulc", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 432, FirstName = "Denis", LastName = "Visinsky", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 17 },

// Forwards
new { Id = 433, FirstName = "Adam", LastName = "Hlozek", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 434, FirstName = "Tomas", LastName = "Chory", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 435, FirstName = "Mojmir", LastName = "Chytil", ShirtNumber = "17", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 436, FirstName = "Jan", LastName = "Kuchta", ShirtNumber = "25", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 17 },
new { Id = 437, FirstName = "Patrik", LastName = "Schick", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 17 }

);

        builder.HasData(

// Goalkeepers
new { Id = 438, FirstName = "Altay", LastName = "Bayindir", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 439, FirstName = "Mert", LastName = "Gunok", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 37, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 440, FirstName = "Ugurcan", LastName = "Cakir", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 18 },

// Defenders
new { Id = 441, FirstName = "Abdulkerim", LastName = "Bardakci", ShirtNumber = "14", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 442, FirstName = "Caglar", LastName = "Soyuncu", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 443, FirstName = "Eren", LastName = "Elmali", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 444, FirstName = "Ferdi", LastName = "Kadioglu", ShirtNumber = "20", Position = PositionEnum.LeftBack, Age = 26, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 445, FirstName = "Merih", LastName = "Demiral", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 446, FirstName = "Mert", LastName = "Muldur", ShirtNumber = "18", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 447, FirstName = "Ozan", LastName = "Kabak", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 448, FirstName = "Samet", LastName = "Akaydin", ShirtNumber = "25", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 449, FirstName = "Zeki", LastName = "Celik", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 18 },

// Midfielders
new { Id = 450, FirstName = "Hakan", LastName = "Calhanoglu", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 451, FirstName = "Ismail", LastName = "Yuksek", ShirtNumber = "16", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 452, FirstName = "Kaan", LastName = "Ayhan", ShirtNumber = "22", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 453, FirstName = "Orkun", LastName = "Kokcu", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 454, FirstName = "Salih", LastName = "Ozcan", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 18 },

// Wingers / Attacking Midfielders
new { Id = 455, FirstName = "Arda", LastName = "Guler", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 21, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 456, FirstName = "Irfan Can", LastName = "Kahveci", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 31, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 457, FirstName = "Oguz", LastName = "Aydin", ShirtNumber = "24", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 458, FirstName = "Yunus", LastName = "Akgun", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 18 },

// Forwards
new { Id = 459, FirstName = "Baris Alper", LastName = "Yilmaz", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 460, FirstName = "Can", LastName = "Uzun", ShirtNumber = "26", Position = PositionEnum.CenterForward, Age = 20, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 461, FirstName = "Deniz", LastName = "Gul", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 22, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 462, FirstName = "Kenan", LastName = "Yildiz", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 18 },
new { Id = 463, FirstName = "Kerem", LastName = "Akturkoglu", ShirtNumber = "10", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 18 }

);

        builder.HasData(

// Goalkeepers
new { Id = 464, FirstName = "Carlos", LastName = "Acevedo", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 465, FirstName = "Guillermo", LastName = "Ochoa", ShirtNumber = "13", Position = PositionEnum.GoalKeeper, Age = 40, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 466, FirstName = "Raul", LastName = "Rangel", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 19 },

// Defenders
new { Id = 467, FirstName = "Edson", LastName = "Alvarez", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 468, FirstName = "Mateo", LastName = "Chavez", ShirtNumber = "20", Position = PositionEnum.LeftBack, Age = 21, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 469, FirstName = "Jesus", LastName = "Gallardo", ShirtNumber = "23", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 470, FirstName = "Cesar", LastName = "Montes", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 471, FirstName = "Israel", LastName = "Reyes", ShirtNumber = "15", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 472, FirstName = "Jorge", LastName = "Sanchez", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 28, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 473, FirstName = "Johan", LastName = "Vasquez", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 19 },

// Midfielders
new { Id = 474, FirstName = "Luis", LastName = "Chavez", ShirtNumber = "24", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 475, FirstName = "Alvaro", LastName = "Fidalgo", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 476, FirstName = "Brian", LastName = "Gutierrez", ShirtNumber = "26", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 477, FirstName = "Erik", LastName = "Lira", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 478, FirstName = "Gilberto", LastName = "Mora", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 17, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 479, FirstName = "Luis", LastName = "Romo", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 480, FirstName = "Orbelin", LastName = "Pineda", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 481, FirstName = "Obed", LastName = "Vargas", ShirtNumber = "18", Position = PositionEnum.CenterMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 19 },

// Forwards
new { Id = 482, FirstName = "Roberto", LastName = "Alvarado", ShirtNumber = "25", Position = PositionEnum.RightWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 483, FirstName = "Armando", LastName = "Gonzalez", ShirtNumber = "14", Position = PositionEnum.CenterForward, Age = 22, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 484, FirstName = "Cesar", LastName = "Huerta", ShirtNumber = "21", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 485, FirstName = "Raul", LastName = "Jimenez", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 35, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 486, FirstName = "Guillermo", LastName = "Martinez", ShirtNumber = "22", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 487, FirstName = "Julian", LastName = "Quinones", ShirtNumber = "16", Position = PositionEnum.LeftWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 488, FirstName = "Santiago", LastName = "Gimenez", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 19 },
new { Id = 489, FirstName = "Alexis", LastName = "Vega", ShirtNumber = "10", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 19 }

);

        builder.HasData(

// Goalkeepers
new { Id = 490, FirstName = "Maxime", LastName = "Crepeau", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 491, FirstName = "Dayne", LastName = "St. Clair", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 492, FirstName = "Owen", LastName = "Goodman", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 20 },

// Defenders
new { Id = 493, FirstName = "Alphonso", LastName = "Davies", ShirtNumber = "19", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 494, FirstName = "Alistair", LastName = "Johnston", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 495, FirstName = "Derek", LastName = "Cornelius", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 496, FirstName = "Moise", LastName = "Bombito", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 497, FirstName = "Richie", LastName = "Laryea", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 30, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 498, FirstName = "Alfie", LastName = "Jones", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 499, FirstName = "Joel", LastName = "Waterman", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 500, FirstName = "Luc", LastName = "De Fougerolles", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 19, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 501, FirstName = "Niko", LastName = "Sigur", ShirtNumber = "14", Position = PositionEnum.RightBAck, Age = 21, Goals = 0, Assist = 0, TeamId = 20 },

// Midfielders
new { Id = 502, FirstName = "Stephen", LastName = "Eustaquio", ShirtNumber = "7", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 503, FirstName = "Ismael", LastName = "Kone", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 504, FirstName = "Jonathan", LastName = "Osorio", ShirtNumber = "21", Position = PositionEnum.CenterMidfilder, Age = 33, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 505, FirstName = "Tajon", LastName = "Buchanan", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 506, FirstName = "Mathieu", LastName = "Choiniere", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 507, FirstName = "Ali", LastName = "Ahmed", ShirtNumber = "18", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 508, FirstName = "Nathan", LastName = "Saliba", ShirtNumber = "22", Position = PositionEnum.DefendCenterMidfilder, Age = 20, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 509, FirstName = "Liam", LastName = "Millar", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 20 },

// Forwards
new { Id = 510, FirstName = "Jonathan", LastName = "David", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 511, FirstName = "Cyle", LastName = "Larin", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 512, FirstName = "Jacob", LastName = "Shaffelburg", ShirtNumber = "14", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 513, FirstName = "Promise", LastName = "David", ShirtNumber = "23", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 20 },
new { Id = 514, FirstName = "Tani", LastName = "Oluwaseyi", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 20 }

);

        builder.HasData(

// Goalkeepers
new { Id = 515, FirstName = "Matt", LastName = "Turner", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 516, FirstName = "Ethan", LastName = "Horvath", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 517, FirstName = "Chris", LastName = "Brady", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 21 },

// Defenders
new { Id = 518, FirstName = "Sergino", LastName = "Dest", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 519, FirstName = "Antonee", LastName = "Robinson", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 520, FirstName = "Tim", LastName = "Ream", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 37, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 521, FirstName = "Chris", LastName = "Richards", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 522, FirstName = "Miles", LastName = "Robinson", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 523, FirstName = "Joe", LastName = "Scally", ShirtNumber = "18", Position = PositionEnum.RightBAck, Age = 22, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 524, FirstName = "Cameron", LastName = "Carter-Vickers", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 21 },

// Midfielders
new { Id = 525, FirstName = "Tyler", LastName = "Adams", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 526, FirstName = "Weston", LastName = "McKennie", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 527, FirstName = "Yunus", LastName = "Musah", ShirtNumber = "11", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 528, FirstName = "Giovanni", LastName = "Reyna", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 529, FirstName = "Luca", LastName = "de la Torre", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 530, FirstName = "Brenden", LastName = "Aaronson", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 531, FirstName = "Malik", LastName = "Tillman", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 532, FirstName = "Johnny", LastName = "Cardoso", ShirtNumber = "15", Position = PositionEnum.DefendCenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 21 },

// Forwards
new { Id = 533, FirstName = "Christian", LastName = "Pulisic", ShirtNumber = "10", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 534, FirstName = "Timothy", LastName = "Weah", ShirtNumber = "21", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 535, FirstName = "Folarin", LastName = "Balogun", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 536, FirstName = "Ricardo", LastName = "Pepi", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 537, FirstName = "Josh", LastName = "Sargent", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 21 },
new { Id = 538, FirstName = "Haji", LastName = "Wright", ShirtNumber = "16", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 21 }

);

        builder.HasData(

// Goalkeepers
new { Id = 539, FirstName = "Luis", LastName = "Mejía", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 540, FirstName = "Orlando", LastName = "Mosquera", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 541, FirstName = "Cesar", LastName = "Samudio", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 22 },

// Defenders
new { Id = 542, FirstName = "Eric", LastName = "Davis", ShirtNumber = "15", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 543, FirstName = "Michael", LastName = "Murillo", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 544, FirstName = "Fidel", LastName = "Escobar", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 545, FirstName = "Jose", LastName = "Cordoba", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 546, FirstName = "Cesar", LastName = "Blackman", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 547, FirstName = "Andres", LastName = "Andrade", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 548, FirstName = "Edgardo", LastName = "Farina", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 549, FirstName = "Jiovany", LastName = "Ramos", ShirtNumber = "14", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 550, FirstName = "Jorge", LastName = "Gutiérrez", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },

// Midfielders
new { Id = 551, FirstName = "Anibal", LastName = "Godoy", ShirtNumber = "20", Position = PositionEnum.DefendCenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 552, FirstName = "Adalberto", LastName = "Carrasquilla", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 553, FirstName = "Jose Luis", LastName = "Rodriguez", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 554, FirstName = "Yoel", LastName = "Barcenas", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 555, FirstName = "Cesar", LastName = "Yanis", ShirtNumber = "19", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 556, FirstName = "Cristian", LastName = "Martinez", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 557, FirstName = "Carlos", LastName = "Harvey", ShirtNumber = "18", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 558, FirstName = "Alberto", LastName = "Quintero", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 37, Goals = 0, Assist = 0, TeamId = 22 },

// Forwards
new { Id = 559, FirstName = "Ismael", LastName = "Diaz", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 560, FirstName = "Cecilio", LastName = "Waterman", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 561, FirstName = "Jose", LastName = "Fajardo", ShirtNumber = "22", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 22 },
new { Id = 562, FirstName = "Tomás", LastName = "Rodriguez", ShirtNumber = "24", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 22 }

);

        builder.HasData(
    // Goalkeepers
    new { Id = 563, FirstName = "Eloy", LastName = "Room", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 37, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 564, FirstName = "Tyrick", LastName = "Bodak", ShirtNumber = "25", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 565, FirstName = "Trevor", LastName = "Doornbusch", ShirtNumber = "26", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 23 },

    // Defenders
    new { Id = 566, FirstName = "Shurandy", LastName = "Sambo", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 567, FirstName = "Jurien", LastName = "Gaari", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 568, FirstName = "Roshon", LastName = "Van Eijma", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 569, FirstName = "Sherel", LastName = "Floranus", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 570, FirstName = "Joshua", LastName = "Brenet", ShirtNumber = "20", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 571, FirstName = "Riechedly", LastName = "Bazoer", ShirtNumber = "23", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 572, FirstName = "Armando", LastName = "Obispo", ShirtNumber = "18", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 573, FirstName = "Deveron", LastName = "Fonville", ShirtNumber = "24", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 23 },

    // Midfielders
    new { Id = 574, FirstName = "Juninho", LastName = "Bacuna", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 575, FirstName = "Leandro", LastName = "Bacuna", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 576, FirstName = "Godfried", LastName = "Roemeratoe", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 577, FirstName = "Kevin", LastName = "Felida", ShirtNumber = "22", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 578, FirstName = "Livano", LastName = "Comenencia", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 579, FirstName = "Tyrese", LastName = "Noslin", ShirtNumber = "13", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 580, FirstName = "Arjany", LastName = "Martha", ShirtNumber = "15", Position = PositionEnum.RightWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 23 },

    // Forwards
    new { Id = 581, FirstName = "Jurgen", LastName = "Locadia", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 582, FirstName = "Jeremy", LastName = "Antonisse", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 583, FirstName = "Sontje", LastName = "Hansen", ShirtNumber = "12", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 584, FirstName = "Kenji", LastName = "Gorre", ShirtNumber = "14", Position = PositionEnum.LeftWinger, Age = 31, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 585, FirstName = "Jearl", LastName = "Margaritha", ShirtNumber = "16", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 586, FirstName = "Brandley", LastName = "Kuwas", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 587, FirstName = "Gervane", LastName = "Kastaneer", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 23 },
    new { Id = 588, FirstName = "Tahith", LastName = "Chong", ShirtNumber = "21", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 23 }
);

        builder.HasData(
    // Goalkeepers
    new { Id = 589, FirstName = "Johny", LastName = "Placide", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 38, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 590, FirstName = "Alexandre", LastName = "Pierre", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 591, FirstName = "Josue", LastName = "Duverger", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 24 },

    // Defenders
    new { Id = 592, FirstName = "Carlens", LastName = "Arcus", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 593, FirstName = "Ricardo", LastName = "Ade", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 594, FirstName = "Jean-Kevin", LastName = "Duverne", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 595, FirstName = "Hannes", LastName = "Delcroix", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 596, FirstName = "Martin", LastName = "Experience", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 597, FirstName = "Duke", LastName = "Lacroix", ShirtNumber = "14", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 598, FirstName = "Wilguens", LastName = "Paugain", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 599, FirstName = "Keeto", LastName = "Thermoncy", ShirtNumber = "16", Position = PositionEnum.CenterBack, Age = 22, Goals = 0, Assist = 0, TeamId = 24 },

    // Midfielders
    new { Id = 600, FirstName = "Jean-Ricner", LastName = "Bellegarde", ShirtNumber = "6", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 601, FirstName = "Danley", LastName = "Jean Jacques", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 602, FirstName = "Leverton", LastName = "Pierre", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 603, FirstName = "Carl Fred", LastName = "Sainte", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 604, FirstName = "Woodensky", LastName = "Pierre", ShirtNumber = "18", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 605, FirstName = "Dominique", LastName = "Simon", ShirtNumber = "20", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },

    // Forwards
    new { Id = 606, FirstName = "Duckens", LastName = "Nazon", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 607, FirstName = "Frantzdy", LastName = "Pierrot", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 608, FirstName = "Wilson", LastName = "Isidor", ShirtNumber = "7", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 609, FirstName = "Josue", LastName = "Casimir", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 610, FirstName = "Louicius", LastName = "Deedson", ShirtNumber = "21", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 611, FirstName = "Derrick", LastName = "Etienne Jr", ShirtNumber = "22", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 612, FirstName = "Yassin", LastName = "Fortune", ShirtNumber = "24", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 613, FirstName = "Lenny", LastName = "Joseph", ShirtNumber = "25", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 24 },
    new { Id = 614, FirstName = "Ruben", LastName = "Providence", ShirtNumber = "26", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 24 }
);

        builder.HasData(

// Goalkeepers
new { Id = 615, FirstName = "Zion", LastName = "Suzuki", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 23, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 616, FirstName = "Kosei", LastName = "Tani", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 617, FirstName = "Daniel", LastName = "Schmidt", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 25 },

// Defenders
new { Id = 618, FirstName = "Takehiro", LastName = "Tomiyasu", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 619, FirstName = "Ko", LastName = "Itakura", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 620, FirstName = "Maya", LastName = "Yoshida", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 36, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 621, FirstName = "Hiroki", LastName = "Sakai", ShirtNumber = "5", Position = PositionEnum.RightBAck, Age = 35, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 622, FirstName = "Yukinari", LastName = "Sugawara", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 623, FirstName = "Yuto", LastName = "Nagatomo", ShirtNumber = "16", Position = PositionEnum.LeftBack, Age = 39, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 624, FirstName = "Ayumu", LastName = "Seko", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 25 },

// Midfielders
new { Id = 625, FirstName = "Wataru", LastName = "Endo", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 626, FirstName = "Hidemasa", LastName = "Morita", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 627, FirstName = "Daichi", LastName = "Kamada", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 628, FirstName = "Ao", LastName = "Tanaka", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 629, FirstName = "Takumi", LastName = "Minamino", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 630, FirstName = "Kaoru", LastName = "Mitoma", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 631, FirstName = "Junya", LastName = "Ito", ShirtNumber = "14", Position = PositionEnum.RightWinger, Age = 32, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 632, FirstName = "Yuki", LastName = "Soma", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 25 },

// Forwards
new { Id = 633, FirstName = "Ayase", LastName = "Ueda", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 634, FirstName = "Daizen", LastName = "Maeda", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 635, FirstName = "Shuto", LastName = "Machino", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 25 },
new { Id = 636, FirstName = "Kyogo", LastName = "Furuhashi", ShirtNumber = "13", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 25 }

);

        builder.HasData(

// Goalkeepers
new { Id = 637, FirstName = "Jo", LastName = "Hyeon-woo", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 638, FirstName = "Kim", LastName = "Seung-gyu", ShirtNumber = "21", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 639, FirstName = "Lee", LastName = "Chang-geun", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 26 },

// Defenders
new { Id = 640, FirstName = "Kim", LastName = "Min-jae", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 641, FirstName = "Kim", LastName = "Young-gwon", ShirtNumber = "19", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 642, FirstName = "Jung", LastName = "Seung-hyun", ShirtNumber = "15", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 643, FirstName = "Kim", LastName = "Jin-su", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 644, FirstName = "Lee", LastName = "Ki-je", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 645, FirstName = "Kim", LastName = "Tae-hwan", ShirtNumber = "23", Position = PositionEnum.RightBAck, Age = 35, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 646, FirstName = "Seol", LastName = "Young-woo", ShirtNumber = "22", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 26 },

// Midfielders
new { Id = 647, FirstName = "Lee", LastName = "Kang-in", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 648, FirstName = "Hwang", LastName = "In-beom", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 649, FirstName = "Paik", LastName = "Seung-ho", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 650, FirstName = "Jeong", LastName = "Woo-yeong", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 651, FirstName = "Hong", LastName = "Hyun-seok", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 652, FirstName = "Lee", LastName = "Jae-sung", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 653, FirstName = "Hwang", LastName = "Hee-chan", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 654, FirstName = "Kim", LastName = "Jin-kyu", ShirtNumber = "18", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 26 },

// Forwards
new { Id = 655, FirstName = "Son", LastName = "Heung-min", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 656, FirstName = "Cho", LastName = "Gue-sung", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 657, FirstName = "Hwang", LastName = "Ui-jo", ShirtNumber = "16", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 26 },
new { Id = 658, FirstName = "Oh", LastName = "Se-hun", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 26 }

);

        builder.HasData(

// Goalkeepers
new { Id = 659, FirstName = "Alireza", LastName = "Beiranvand", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 660, FirstName = "Seyed Hossein", LastName = "Hosseini", ShirtNumber = "22", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 661, FirstName = "Payam", LastName = "Niazmand", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 27 },

// Defenders
new { Id = 662, FirstName = "Morteza", LastName = "Pouraliganji", ShirtNumber = "8", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 663, FirstName = "Hossein", LastName = "Kanaani", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 664, FirstName = "Shoja", LastName = "Khalilzadeh", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 665, FirstName = "Ramin", LastName = "Rezaeian", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 34, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 666, FirstName = "Milad", LastName = "Mohammadi", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 667, FirstName = "Saeid", LastName = "Moharrami", ShirtNumber = "19", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 27 },

// Midfielders
new { Id = 668, FirstName = "Ehsan", LastName = "Hajsafi", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 669, FirstName = "Saman", LastName = "Ghoddos", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 670, FirstName = "Alireza", LastName = "Jahanbakhsh", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 31, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 671, FirstName = "Mehdi", LastName = "Taremi", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 672, FirstName = "Sardar", LastName = "Azmoun", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 673, FirstName = "Mehdi", LastName = "Ghayedi", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 674, FirstName = "Mohammad", LastName = "Mohebi", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 675, FirstName = "Ali", LastName = "Gholizadeh", ShirtNumber = "18", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 27 },

// Forwards
new { Id = 676, FirstName = "Kaveh", LastName = "Rezaei", ShirtNumber = "16", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 677, FirstName = "Shahriar", LastName = "Moghanlou", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 27 },
new { Id = 678, FirstName = "Amirhossein", LastName = "Hossein-Zadeh", ShirtNumber = "23", Position = PositionEnum.LeftWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 27 }

);

        builder.HasData(

// Goalkeepers
new { Id = 679, FirstName = "Mathew", LastName = "Ryan", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 680, FirstName = "Joe", LastName = "Gauci", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 681, FirstName = "Paul", LastName = "Izzo", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 28 },

// Defenders
new { Id = 682, FirstName = "Aziz", LastName = "Behich", ShirtNumber = "16", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 683, FirstName = "Nathaniel", LastName = "Atkinson", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 26, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 684, FirstName = "Kye", LastName = "Rowles", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 685, FirstName = "Harry", LastName = "Souttar", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 686, FirstName = "Joel", LastName = "King", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 24, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 687, FirstName = "Milos", LastName = "Degenek", ShirtNumber = "22", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 688, FirstName = "Thomas", LastName = "Deng", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 28 },

// Midfielders
new { Id = 689, FirstName = "Aaron", LastName = "Mooy", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 690, FirstName = "Jackson", LastName = "Irvine", ShirtNumber = "13", Position = PositionEnum.DefendCenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 691, FirstName = "Ajdin", LastName = "Hrustic", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 692, FirstName = "Keanu", LastName = "Baccus", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 693, FirstName = "Connor", LastName = "Metcalfe", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 694, FirstName = "Cameron", LastName = "Devlin", ShirtNumber = "15", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 695, FirstName = "Riley", LastName = "McGree", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 28 },

// Forwards
new { Id = 696, FirstName = "Mathew", LastName = "Leckie", ShirtNumber = "9", Position = PositionEnum.RightWinger, Age = 34, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 697, FirstName = "Craig", LastName = "Goodwin", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 698, FirstName = "Jamie", LastName = "Maclaren", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 699, FirstName = "Brandon", LastName = "Borrello", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 28 },
new { Id = 700, FirstName = "Marco", LastName = "Tilio", ShirtNumber = "21", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 28 }

);

        builder.HasData(

// Goalkeepers
new { Id = 701, FirstName = "Mohammed", LastName = "Al-Owais", ShirtNumber = "21", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 702, FirstName = "Nawaf", LastName = "Al-Aqidi", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 703, FirstName = "Raghed", LastName = "Al-Najjar", ShirtNumber = "22", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 29 },

// Defenders
new { Id = 704, FirstName = "Sultan", LastName = "Al-Ghannam", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 705, FirstName = "Yasser", LastName = "Al-Shahrani", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 33, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 706, FirstName = "Abdulelah", LastName = "Al-Amri", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 707, FirstName = "Hassan", LastName = "Tambakti", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 708, FirstName = "Ali", LastName = "Al-Bulaihi", ShirtNumber = "17", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 709, FirstName = "Mohammed", LastName = "Al-Breik", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 29 },

// Midfielders
new { Id = 710, FirstName = "Salman", LastName = "Al-Faraj", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 711, FirstName = "Abdullah", LastName = "Otayf", ShirtNumber = "14", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 712, FirstName = "Mohamed", LastName = "Kanno", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 713, FirstName = "Nasser", LastName = "Al-Dawsari", ShirtNumber = "16", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 714, FirstName = "Fahad", LastName = "Al-Muwallad", ShirtNumber = "9", Position = PositionEnum.RightWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 715, FirstName = "Sami", LastName = "Al-Najei", ShirtNumber = "15", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 716, FirstName = "Abdulrahman", LastName = "Al-Aboud", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 29 },

// Forwards
new { Id = 717, FirstName = "Saleh", LastName = "Al-Shehri", ShirtNumber = "11", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 718, FirstName = "Firas", LastName = "Al-Buraikan", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 719, FirstName = "Abdulaziz", LastName = "Al-Bishi", ShirtNumber = "20", Position = PositionEnum.RightWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 29 },
new { Id = 720, FirstName = "Hussain", LastName = "Al-Qahtani", ShirtNumber = "23", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 29 }

);

        builder.HasData(

// Goalkeepers
new { Id = 721, FirstName = "Saad", LastName = "Al-Sheeb", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 722, FirstName = "Meshaal", LastName = "Barsham", ShirtNumber = "22", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 723, FirstName = "Yousef", LastName = "Hassan", ShirtNumber = "21", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 30 },

// Defenders
new { Id = 724, FirstName = "Pedro", LastName = "Miguel", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 725, FirstName = "Boualem", LastName = "Khoukhi", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 726, FirstName = "Bassam", LastName = "Al-Rawi", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 727, FirstName = "Tarek", LastName = "Salman", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 728, FirstName = "Abdelkarim", LastName = "Hassan", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 729, FirstName = "Hamid", LastName = "Ismaeil", ShirtNumber = "15", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 30 },

// Midfielders
new { Id = 730, FirstName = "Hassan", LastName = "Al-Haydos", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 731, FirstName = "Abdulaziz", LastName = "Hatem", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 33, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 732, FirstName = "Karim", LastName = "Boudiaf", ShirtNumber = "12", Position = PositionEnum.DefendCenterMidfilder, Age = 33, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 733, FirstName = "Assim", LastName = "Madibo", ShirtNumber = "11", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 734, FirstName = "Ahmed", LastName = "Fathy", ShirtNumber = "16", Position = PositionEnum.RightWinger, Age = 31, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 735, FirstName = "Mohammed", LastName = "Waad", ShirtNumber = "14", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 736, FirstName = "Yusuf", LastName = "Abdurisag", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 30 },

// Forwards
new { Id = 737, FirstName = "Almoez", LastName = "Ali", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 738, FirstName = "Akram", LastName = "Afif", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 739, FirstName = "Mohammed", LastName = "Muntari", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 30 },
new { Id = 740, FirstName = "Ahmed", LastName = "Alaaeldin", ShirtNumber = "23", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 30 }

);

        builder.HasData(

// Goalkeepers
new { Id = 741, FirstName = "Utkir", LastName = "Yusupov", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 742, FirstName = "Abduvohid", LastName = "Nematov", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 743, FirstName = "Rustam", LastName = "Yatimov", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 31 },

// Defenders
new { Id = 744, FirstName = "Eldor", LastName = "Shomurodov", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 745, FirstName = "Abdukodir", LastName = "Khusanov", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 20, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 746, FirstName = "Rustamjon", LastName = "Ashurmatov", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 747, FirstName = "Oybek", LastName = "Bozorov", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 748, FirstName = "Dostonbek", LastName = "Tursunov", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 29, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 749, FirstName = "Khojimat", LastName = "Erkinov", ShirtNumber = "2", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 31 },

// Midfielders
new { Id = 750, FirstName = "Odiljon", LastName = "Xamrobekov", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 751, FirstName = "Ibrokhim", LastName = "Halilov", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 752, FirstName = "Jaloliddin", LastName = "Masharipov", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 753, FirstName = "Otabek", LastName = "Shukurov", ShirtNumber = "11", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 754, FirstName = "Sardor", LastName = "Rakhmonov", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 755, FirstName = "Bobur", LastName = "Abdukholikov", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 756, FirstName = "Khoja", LastName = "Matyokubov", ShirtNumber = "16", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 31 },

// Forwards
new { Id = 757, FirstName = "Eldor", LastName = "Shomurodov", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 758, FirstName = "Igor", LastName = "Sergeev", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 759, FirstName = "Javokhir", LastName = "Siddikov", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 31 },
new { Id = 760, FirstName = "Azizbek", LastName = "Turgunboev", ShirtNumber = "20", Position = PositionEnum.RightWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 31 }

);

        builder.HasData(

// Goalkeepers
new { Id = 761, FirstName = "Yazeed", LastName = "Abulaila", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 762, FirstName = "Malek", LastName = "Shaboul", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 763, FirstName = "Rami", LastName = "Hamadeh", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 32 },

// Defenders
new { Id = 764, FirstName = "Ahmad", LastName = "Erdem", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 765, FirstName = "Yazan", LastName = "Al-Arab", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 766, FirstName = "Abdallah", LastName = "Nasib", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 767, FirstName = "Mohannad", LastName = "Abu Taha", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 768, FirstName = "Salem", LastName = "Al-Ajalin", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 769, FirstName = "Shadi", LastName = "Abu Hashish", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 32 },

// Midfielders
new { Id = 770, FirstName = "Baha", LastName = "Seif", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 771, FirstName = "Nizar", LastName = "Al-Rashdan", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 772, FirstName = "Ehsan", LastName = "Haddad", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 773, FirstName = "Yousef", LastName = "Rawshdeh", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 774, FirstName = "Abdulrahman", LastName = "Al-Mardi", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 775, FirstName = "Musa", LastName = "Al-Taamari", ShirtNumber = "9", Position = PositionEnum.RightWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 776, FirstName = "Ali", LastName = "Olwan", ShirtNumber = "15", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 32 },

// Forwards
new { Id = 777, FirstName = "Yazan", LastName = "Al-Naimat", ShirtNumber = "16", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 778, FirstName = "Omar", LastName = "Hani", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 779, FirstName = "Ibrahim", LastName = "Sadeh", ShirtNumber = "18", Position = PositionEnum.RightWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 32 },
new { Id = 780, FirstName = "Mohammad", LastName = "Abu Zraiq", ShirtNumber = "20", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 32 }

);

        builder.HasData(

// Goalkeepers
new { Id = 781, FirstName = "Jalal", LastName = "Hassan", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 782, FirstName = "Faris", LastName = "Nadhim", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 783, FirstName = "Mohammed", LastName = "Hameed", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 33 },

// Defenders
new { Id = 784, FirstName = "Ali", LastName = "Adnan", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 785, FirstName = "Rebin", LastName = "Sulaqa", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 786, FirstName = "Ahmed", LastName = "Ibrahim", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 787, FirstName = "Zaid", LastName = "Tahseen", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 788, FirstName = "Frans", LastName = "Dhia Putros", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 789, FirstName = "Ali", LastName = "Faez", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 28, Goals = 0, Assist = 0, TeamId = 33 },

// Midfielders
new { Id = 790, FirstName = "Aymen", LastName = "Hussein", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 791, FirstName = "Mohannad", LastName = "Ali", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 792, FirstName = "Amir", LastName = "Al-Ammari", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 793, FirstName = "Osama", LastName = "Rasheed", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 794, FirstName = "Mahmoud", LastName = "Al-Mawas", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 795, FirstName = "Justin", LastName = "Meram", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 796, FirstName = "Zidane", LastName = "Iqbal", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 33 },

// Forwards
new { Id = 797, FirstName = "Youssef", LastName = "Amyn", ShirtNumber = "16", Position = PositionEnum.LeftWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 798, FirstName = "Bashar", LastName = "Resan", ShirtNumber = "17", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 799, FirstName = "Mohammed", LastName = "Qasim", ShirtNumber = "18", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 33 },
new { Id = 800, FirstName = "Ali", LastName = "Al-Hamadi", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 33 }

);

        builder.HasData(

// Goalkeepers
new { Id = 801, FirstName = "Yassine", LastName = "Bounou", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 34, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 802, FirstName = "Munir", LastName = "El Kajoui", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 36, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 803, FirstName = "Anas", LastName = "Zniti", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 35, Goals = 0, Assist = 0, TeamId = 34 },

// Defenders
new { Id = 804, FirstName = "Achraf", LastName = "Hakimi", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 805, FirstName = "Noussair", LastName = "Mazraoui", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 806, FirstName = "Romain", LastName = "Saïss", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 35, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 807, FirstName = "Nayef", LastName = "Aguerd", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 808, FirstName = "Jawad", LastName = "El Yamiq", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 809, FirstName = "Adam", LastName = "Masina", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 34 },

// Midfielders
new { Id = 810, FirstName = "Sofyan", LastName = "Amrabat", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 811, FirstName = "Azzedine", LastName = "Ounahi", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 812, FirstName = "Bilal", LastName = "El Khannouss", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 21, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 813, FirstName = "Selim", LastName = "Amallah", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 814, FirstName = "Amine", LastName = "Harit", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 815, FirstName = "Zakaria", LastName = "Aboukhlal", ShirtNumber = "15", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 816, FirstName = "Abde", LastName = "Ezzalzouli", ShirtNumber = "16", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 34 },

// Forwards
new { Id = 817, FirstName = "Youssef", LastName = "En-Nesyri", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 818, FirstName = "Sofiane", LastName = "Boufal", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 819, FirstName = "Walid", LastName = "Cheddira", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 34 },
new { Id = 820, FirstName = "Ilias", LastName = "Akhomach", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 34 }

);

        builder.HasData(

// Goalkeepers
new { Id = 821, FirstName = "Edouard", LastName = "Mendy", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 822, FirstName = "Alfred", LastName = "Gomis", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 823, FirstName = "Seny", LastName = "Dieng", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 35 },

// Defenders
new { Id = 824, FirstName = "Kalidou", LastName = "Koulibaly", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 825, FirstName = "Abdou", LastName = "Diallo", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 826, FirstName = "Moussa", LastName = "Ndiaye", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 23, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 827, FirstName = "Youssouf", LastName = "Sabaly", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 828, FirstName = "Pape", LastName = "Abou Cisse", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 829, FirstName = "Formose", LastName = "Mendy", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 35 },

// Midfielders
new { Id = 830, FirstName = "Idrissa", LastName = "Gueye", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 831, FirstName = "Nampalys", LastName = "Mendy", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 832, FirstName = "Pape", LastName = "Gueye", ShirtNumber = "17", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 833, FirstName = "Krepin", LastName = "Diatta", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 834, FirstName = "Ismaila", LastName = "Sarr", ShirtNumber = "10", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 835, FirstName = "Habib", LastName = "Diallo", ShirtNumber = "15", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 836, FirstName = "Pape Matar", LastName = "Sarr", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 35 },

// Forwards
new { Id = 837, FirstName = "Sadio", LastName = "Mane", ShirtNumber = "9", Position = PositionEnum.LeftWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 838, FirstName = "Boulaye", LastName = "Dia", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 839, FirstName = "Iliman", LastName = "Ndiaye", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 35 },
new { Id = 840, FirstName = "Cheikh", LastName = "Sabaly", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 35 }

);

        builder.HasData(

// Goalkeepers
new { Id = 841, FirstName = "Mohamed", LastName = "El-Shenawy", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 36, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 842, FirstName = "Mohamed", LastName = "Sobhi", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 843, FirstName = "Mostafa", LastName = "Shobeir", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 36 },

// Defenders
new { Id = 844, FirstName = "Ahmed", LastName = "Hegazi", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 845, FirstName = "Mohamed", LastName = "Abdelmonem", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 846, FirstName = "Omar", LastName = "Kamal", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 28, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 847, FirstName = "Ahmed", LastName = "Fatouh", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 848, FirstName = "Rami", LastName = "Rabia", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 849, FirstName = "Mohamed", LastName = "Hany", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 36 },

// Midfielders
new { Id = 850, FirstName = "Mohamed", LastName = "Elneny", ShirtNumber = "17", Position = PositionEnum.DefendCenterMidfilder, Age = 33, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 851, FirstName = "Tarek", LastName = "Hamed", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 852, FirstName = "Hamdy", LastName = "Fathi", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 853, FirstName = "Emam", LastName = "Ashour", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 854, FirstName = "Marwan", LastName = "Attia", ShirtNumber = "11", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 855, FirstName = "Ahmed", LastName = "Sayed Zizo", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 856, FirstName = "Mahmoud", LastName = "Hassan Trezeguet", ShirtNumber = "9", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 36 },

// Forwards
new { Id = 857, FirstName = "Mohamed", LastName = "Salah", ShirtNumber = "10", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 858, FirstName = "Mostafa", LastName = "Mohamed", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 859, FirstName = "Ahmed", LastName = "Kouka", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 32, Goals = 0, Assist = 0, TeamId = 36 },
new { Id = 860, FirstName = "Osama", LastName = "Faisal", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 36 }

);

        builder.HasData(

// Goalkeepers
new { Id = 861, FirstName = "Anthony", LastName = "Mandrea", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 862, FirstName = "Alexis", LastName = "Guendouz", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 863, FirstName = "Oussama", LastName = "Benbot", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 37 },

// ➕ NEW Goalkeeper
new { Id = 864, FirstName = "Luca", LastName = "Zidane", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 37 },

// Defenders
new { Id = 865, FirstName = "Ramy", LastName = "Bensebaini", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 30, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 866, FirstName = "Aïssa", LastName = "Mandi", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 867, FirstName = "Mohamed", LastName = "Tougaï", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 868, FirstName = "Kevin", LastName = "Guitoun", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 869, FirstName = "Farès", LastName = "Chaïbi", ShirtNumber = "13", Position = PositionEnum.CenterMidfilder, Age = 21, Goals = 0, Assist = 0, TeamId = 37 },

// Midfielders
new { Id = 870, FirstName = "Ismaël", LastName = "Bennacer", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 871, FirstName = "Sofiane", LastName = "Feghouli", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 872, FirstName = "Ramiz", LastName = "Zerrouki", ShirtNumber = "14", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 873, FirstName = "Houssem", LastName = "Aouar", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 874, FirstName = "Adam", LastName = "Ounas", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 875, FirstName = "Youcef", LastName = "Belaili", ShirtNumber = "15", Position = PositionEnum.LeftWinger, Age = 32, Goals = 0, Assist = 0, TeamId = 37 },

// Forwards
new { Id = 876, FirstName = "Riyad", LastName = "Mahrez", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 34, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 877, FirstName = "Islam", LastName = "Slimani", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 37, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 878, FirstName = "Mohamed", LastName = "Amoura", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 37 },
new { Id = 879, FirstName = "Said", LastName = "Benrahma", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 30, Goals = 0, Assist = 0, TeamId = 37 }

);

        builder.HasData(

// Goalkeepers
new { Id = 881, FirstName = "Ronwen", LastName = "Williams", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 33, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 882, FirstName = "Veli", LastName = "Mothwa", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 883, FirstName = "Ricardo", LastName = "Goss", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 38 },

// Defenders
new { Id = 884, FirstName = "Thapelo", LastName = "Xoki", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 885, FirstName = "Ramahlwe", LastName = "Mphahlele", ShirtNumber = "3", Position = PositionEnum.RightBAck, Age = 35, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 886, FirstName = "Nkosinathi", LastName = "Sibisi", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 887, FirstName = "Aubrey", LastName = "Modiba", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 29, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 888, FirstName = "Siyanda", LastName = "Xulu", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 889, FirstName = "Thibang", LastName = "Phete", ShirtNumber = "13", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 38 },

// Midfielders
new { Id = 890, FirstName = "Andile", LastName = "Jali", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 891, FirstName = "Teboho", LastName = "Mokoena", ShirtNumber = "4", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 892, FirstName = "Mahlobo", LastName = "Sibiya", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 893, FirstName = "Sipho", LastName = "Mbule", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 894, FirstName = "Sphephelo", LastName = "Sithole", ShirtNumber = "14", Position = PositionEnum.DefendCenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 895, FirstName = "Percy", LastName = "Tau", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 31, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 896, FirstName = "Themba", LastName = "Zwane", ShirtNumber = "9", Position = PositionEnum.AttackingMidfilder, Age = 35, Goals = 0, Assist = 0, TeamId = 38 },

// Forwards
new { Id = 897, FirstName = "Lyle", LastName = "Foster", ShirtNumber = "10", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 898, FirstName = "Iqraam", LastName = "Rayners", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 899, FirstName = "Zakhele", LastName = "Lepasa", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 38 },
new { Id = 900, FirstName = "Cassius", LastName = "Mailula", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 38 }

);

        builder.HasData(

// Goalkeepers
new { Id = 901, FirstName = "André", LastName = "Onana", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 902, FirstName = "Lawrence", LastName = "Ati-Zigi", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 903, FirstName = "Richard", LastName = "Ofori", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 39 },

// Defenders
new { Id = 904, FirstName = "Daniel", LastName = "Amartey", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 905, FirstName = "Alexander", LastName = "Djiku", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 906, FirstName = "Mohammed", LastName = "Salisu", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 907, FirstName = "Alidu", LastName = "Seidu", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 25, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 908, FirstName = "Baba", LastName = "Rahman", ShirtNumber = "6", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 909, FirstName = "Tariq", LastName = "Lamptey", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 24, Goals = 0, Assist = 0, TeamId = 39 },

// Midfielders
new { Id = 910, FirstName = "Thomas", LastName = "Partey", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 911, FirstName = "Mubarak", LastName = "Wakaso", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 912, FirstName = "Elisha", LastName = "Owusu", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 913, FirstName = "Iddrisu", LastName = "Baba", ShirtNumber = "15", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 914, FirstName = "Kamal", LastName = "Sowah", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 915, FirstName = "Mohammed", LastName = "Kudus", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 916, FirstName = "Antoine", LastName = "Semenyo", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 39 },

// Forwards
new { Id = 917, FirstName = "Inaki", LastName = "Williams", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 918, FirstName = "Jordan", LastName = "Ayew", ShirtNumber = "18", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 919, FirstName = "Andre", LastName = "Ayew", ShirtNumber = "19", Position = PositionEnum.LeftWinger, Age = 35, Goals = 0, Assist = 0, TeamId = 39 },
new { Id = 920, FirstName = "Ernest", LastName = "Nuamah", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 21, Goals = 0, Assist = 0, TeamId = 39 }

);

        builder.HasData(

// Goalkeepers
new { Id = 921, FirstName = "Aymen", LastName = "Dahmen", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 922, FirstName = "Béchir", LastName = "Ben Said", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 923, FirstName = "Farouk", LastName = "Ben Mustapha", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 35, Goals = 0, Assist = 0, TeamId = 40 },

// Defenders
new { Id = 924, FirstName = "Dylan", LastName = "Bronn", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 925, FirstName = "Nader", LastName = "Ghandri", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 926, FirstName = "Montassar", LastName = "Talbi", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 927, FirstName = "Ali", LastName = "Abdi", ShirtNumber = "5", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 928, FirstName = "Hamza", LastName = "Mathlouthi", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 929, FirstName = "Mortadha", LastName = "Ben Ouanes", ShirtNumber = "13", Position = PositionEnum.LeftBack, Age = 28, Goals = 0, Assist = 0, TeamId = 40 },

// Midfielders
new { Id = 930, FirstName = "Aïssa", LastName = "Laïdouni", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 931, FirstName = "Ellyes", LastName = "Skhiri", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 932, FirstName = "Mohamed", LastName = "Ali Ben Romdhane", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 933, FirstName = "Ferjani", LastName = "Sassi", ShirtNumber = "7", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 934, FirstName = "Issam", LastName = "Jebali", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 32, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 935, FirstName = "Anis", LastName = "Ben Slimane", ShirtNumber = "15", Position = PositionEnum.LeftWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 936, FirstName = "Oussama", LastName = "Haddadi", ShirtNumber = "17", Position = PositionEnum.DefendCenterMidfilder, Age = 33, Goals = 0, Assist = 0, TeamId = 40 },

// Forwards
new { Id = 937, FirstName = "Wahbi", LastName = "Khazri", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 33, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 938, FirstName = "Seifeddine", LastName = "Jaziri", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 939, FirstName = "Youssef", LastName = "Msakni", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 34, Goals = 0, Assist = 0, TeamId = 40 },
new { Id = 940, FirstName = "Naim", LastName = "Sliti", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 32, Goals = 0, Assist = 0, TeamId = 40 }

);

        builder.HasData(

// Goalkeepers
new { Id = 941, FirstName = "Yahia", LastName = "Fofana", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 942, FirstName = "Sylvain", LastName = "Gbohouo", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 36, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 943, FirstName = "Badra", LastName = "Ali Sangaré", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 41 },

// Defenders
new { Id = 944, FirstName = "Serges", LastName = "Aurier", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 945, FirstName = "Ghislain", LastName = "Konan", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 29, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 946, FirstName = "Eric", LastName = "Bailly", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 947, FirstName = "Wilfried", LastName = "Kanon", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 948, FirstName = "Odilon", LastName = "Kossounou", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 24, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 949, FirstName = "Jean-Philippe", LastName = "Gbamin", ShirtNumber = "13", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 41 },

// Midfielders
new { Id = 950, FirstName = "Franck", LastName = "Kessié", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 951, FirstName = "Seko", LastName = "Fofana", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 952, FirstName = "Cheick", LastName = "Doucouré", ShirtNumber = "14", Position = PositionEnum.DefendCenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 953, FirstName = "Hamed", LastName = "Traoré", ShirtNumber = "11", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 954, FirstName = "Maxwel", LastName = "Cornet", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 955, FirstName = "Nicolas", LastName = "Pépé", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 956, FirstName = "Simon", LastName = "Adingra", ShirtNumber = "15", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 41 },

// Forwards
new { Id = 957, FirstName = "Sebastien", LastName = "Haller", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 958, FirstName = "Jean-Philippe", LastName = "Krasso", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 27, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 959, FirstName = "Arnaud", LastName = "Kalimuendo", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 23, Goals = 0, Assist = 0, TeamId = 41 },
new { Id = 960, FirstName = "Amad", LastName = "Diallo", ShirtNumber = "20", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 41 }

);

        builder.HasData(

// Goalkeepers
new { Id = 961, FirstName = "Lionel", LastName = "Mpasi", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 962, FirstName = "Hervé", LastName = "Koffi", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 963, FirstName = "Matthieu", LastName = "Epolo", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 20, Goals = 0, Assist = 0, TeamId = 42 },

// Defenders
new { Id = 964, FirstName = "Chancel", LastName = "Mbemba", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 965, FirstName = "Arthur", LastName = "Masuaku", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 31, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 966, FirstName = "Gédéon", LastName = "Kakuta", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 967, FirstName = "Ilaix", LastName = "Moriba", ShirtNumber = "6", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 968, FirstName = "Glody", LastName = "Ngonda", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 969, FirstName = "Jordan", LastName = "Ikoko", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 42 },

// Midfielders
new { Id = 970, FirstName = "Samuel", LastName = "Moutoussamy", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 971, FirstName = "Charles", LastName = "Pickel", ShirtNumber = "10", Position = PositionEnum.DefendCenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 972, FirstName = "Yoane", LastName = "Wissa", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 973, FirstName = "Théo", LastName = "Bongonda", ShirtNumber = "14", Position = PositionEnum.RightWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 974, FirstName = "Meschack", LastName = "Elia", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 975, FirstName = "Dylan", LastName = "Batubinsika", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 976, FirstName = "Cédric", LastName = "Bakambu", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 34, Goals = 0, Assist = 0, TeamId = 42 },

// Forwards
new { Id = 977, FirstName = "Simon", LastName = "Banza", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 978, FirstName = "Jackson", LastName = "Muleka", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 979, FirstName = "Theo", LastName = "Bongonda", ShirtNumber = "20", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 42 },
new { Id = 980, FirstName = "Afimico", LastName = "Pululu", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 25, Goals = 0, Assist = 0, TeamId = 42 }

);

        builder.HasData(

// Goalkeepers
new { Id = 981, FirstName = "Vozinha", LastName = "da Luz", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 38, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 982, FirstName = "Marcos", LastName = "Roberto", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 30, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 983, FirstName = "Jandrei", LastName = "Oliveira", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 28, Goals = 0, Assist = 0, TeamId = 43 },

// Defenders
new { Id = 984, FirstName = "Stopira", LastName = "Gonçalves", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 36, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 985, FirstName = "Steven", LastName = "Fortes", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 986, FirstName = "Logan", LastName = "Costa", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 25, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 987, FirstName = "Diney", LastName = "Pinto", ShirtNumber = "5", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 988, FirstName = "Nuno", LastName = "Tavares", ShirtNumber = "6", Position = PositionEnum.LeftBack, Age = 25, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 989, FirstName = "João", LastName = "Paulo", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 43 },

// Midfielders
new { Id = 990, FirstName = "Rúben", LastName = "Semedo", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 991, FirstName = "Kevin", LastName = "Pina", ShirtNumber = "10", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 992, FirstName = "Ryan", LastName = "Mendes", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 993, FirstName = "Jamiro", LastName = "Monteiro", ShirtNumber = "14", Position = PositionEnum.AttackingMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 994, FirstName = "Garry", LastName = "Rodrigues", ShirtNumber = "7", Position = PositionEnum.RightWinger, Age = 33, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 995, FirstName = "Patrick", LastName = "Andrade", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 32, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 996, FirstName = "Lisandro", LastName = "Semedo", ShirtNumber = "17", Position = PositionEnum.LeftWinger, Age = 27, Goals = 0, Assist = 0, TeamId = 43 },

// Forwards
new { Id = 997, FirstName = "Bebé", LastName = "Ramos", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 34, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 998, FirstName = "Henrique", LastName = "Tavares", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 999, FirstName = "Elton", LastName = "Monteiro", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 43 },
new { Id = 1000, FirstName = "Jovane", LastName = "Cabral", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 43 }

);

        builder.HasData(

// Goalkeepers
new { Id = 1001, FirstName = "Sergio", LastName = "Rochet", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1002, FirstName = "Santiago", LastName = "Mele", ShirtNumber = "16", Position = PositionEnum.GoalKeeper, Age = 27, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1003, FirstName = "Franco", LastName = "Israel", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 24, Goals = 0, Assist = 0, TeamId = 45 },

// Defenders
new { Id = 1004, FirstName = "José", LastName = "Giménez", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 30, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1005, FirstName = "Ronald", LastName = "Araújo", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 26, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1006, FirstName = "Matías", LastName = "Viña", ShirtNumber = "3", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1007, FirstName = "Nahitan", LastName = "Nández", ShirtNumber = "8", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1008, FirstName = "Sebastián", LastName = "Coates", ShirtNumber = "6", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1009, FirstName = "Guillermo", LastName = "Varela", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 32, Goals = 0, Assist = 0, TeamId = 45 },

// Midfielders
new { Id = 1010, FirstName = "Federico", LastName = "Valverde", ShirtNumber = "10", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1011, FirstName = "Rodrigo", LastName = "Bentancur", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1012, FirstName = "Manuel", LastName = "Ugarte", ShirtNumber = "5", Position = PositionEnum.DefendCenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1013, FirstName = "Nicolás", LastName = "De la Cruz", ShirtNumber = "7", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1014, FirstName = "Giorgian", LastName = "De Arrascaeta", ShirtNumber = "11", Position = PositionEnum.AttackingMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1015, FirstName = "Lucas", LastName = "Torreira", ShirtNumber = "15", Position = PositionEnum.DefendCenterMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1016, FirstName = "Facundo", LastName = "Pellistri", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 24, Goals = 0, Assist = 0, TeamId = 45 },

// Forwards
new { Id = 1017, FirstName = "Darwin", LastName = "Núñez", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 26, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1018, FirstName = "Luis", LastName = "Suárez", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 39, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1019, FirstName = "Maximiliano", LastName = "Gómez", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 45 },
new { Id = 1020, FirstName = "Brian", LastName = "Rodríguez", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 45 }

);

        builder.HasData(

// Goalkeepers
new { Id = 1021, FirstName = "David", LastName = "Ospina", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 37, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1022, FirstName = "Camilo", LastName = "Vargas", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 36, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1023, FirstName = "Kevin", LastName = "Mier", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 46 },

// Defenders
new { Id = 1024, FirstName = "Davinson", LastName = "Sánchez", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 29, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1025, FirstName = "Yerry", LastName = "Mina", ShirtNumber = "13", Position = PositionEnum.CenterBack, Age = 31, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1026, FirstName = "Jhon", LastName = "Lucumí", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 27, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1027, FirstName = "Daniel", LastName = "Muñoz", ShirtNumber = "2", Position = PositionEnum.RightBAck, Age = 29, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1028, FirstName = "Santiago", LastName = "Arias", ShirtNumber = "6", Position = PositionEnum.RightBAck, Age = 33, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1029, FirstName = "Frank", LastName = "Fabra", ShirtNumber = "17", Position = PositionEnum.LeftBack, Age = 34, Goals = 0, Assist = 0, TeamId = 46 },

// Midfielders
new { Id = 1030, FirstName = "Jefferson", LastName = "Lerma", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1031, FirstName = "Mateus", LastName = "Uribe", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1032, FirstName = "Wilmar", LastName = "Barrios", ShirtNumber = "5", Position = PositionEnum.DefendCenterMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1033, FirstName = "James", LastName = "Rodríguez", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1034, FirstName = "Jhon", LastName = "Arias", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1035, FirstName = "Luis", LastName = "Díaz", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1036, FirstName = "Richard", LastName = "Ríos", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 46 },

// Forwards
new { Id = 1037, FirstName = "Rafael", LastName = "Borré", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 30, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1038, FirstName = "Jhon", LastName = "Córdoba", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 31, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1039, FirstName = "Julián", LastName = "Quiñones", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 28, Goals = 0, Assist = 0, TeamId = 46 },
new { Id = 1040, FirstName = "Duván", LastName = "Zapata", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 34, Goals = 0, Assist = 0, TeamId = 46 }

);

        builder.HasData(

// Goalkeepers
new { Id = 1041, FirstName = "Hernán", LastName = "Galíndez", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 38, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1042, FirstName = "Alexander", LastName = "Domínguez", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 38, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1043, FirstName = "Moises", LastName = "Ramírez", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 25, Goals = 0, Assist = 0, TeamId = 47 },

// Defenders
new { Id = 1044, FirstName = "Piero", LastName = "Hincapié", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 23, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1045, FirstName = "Félix", LastName = "Torres", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 28, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1046, FirstName = "Robert", LastName = "Arboleda", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1047, FirstName = "Pervis", LastName = "Estupiñán", ShirtNumber = "7", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1048, FirstName = "Ángelo", LastName = "Preciado", ShirtNumber = "17", Position = PositionEnum.RightBAck, Age = 27, Goals = 0, Assist = 0, TeamId = 47 },

// Midfielders
new { Id = 1049, FirstName = "Moisés", LastName = "Caicedo", ShirtNumber = "8", Position = PositionEnum.DefendCenterMidfilder, Age = 24, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1050, FirstName = "Carlos", LastName = "Gruezo", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 30, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1051, FirstName = "José", LastName = "Cifuentes", ShirtNumber = "16", Position = PositionEnum.CenterMidfilder, Age = 26, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1052, FirstName = "Alan", LastName = "Franco", ShirtNumber = "15", Position = PositionEnum.AttackingMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1053, FirstName = "Jeremy", LastName = "Sarmiento", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1054, FirstName = "Gonzalo", LastName = "Plata", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1055, FirstName = "Nilson", LastName = "Angulo", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 22, Goals = 0, Assist = 0, TeamId = 47 },

// Forwards
new { Id = 1056, FirstName = "Enner", LastName = "Valencia", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 36, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1057, FirstName = "Michael", LastName = "Estrada", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 47 },
new { Id = 1058, FirstName = "Kevin", LastName = "Rodríguez", ShirtNumber = "21", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 47 }

);

        builder.HasData(

// Goalkeepers
new { Id = 1059, FirstName = "Carlos", LastName = "Gorosoito", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 37, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1060, FirstName = "Juan", LastName = "Espínola", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 31, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1061, FirstName = "Santiago", LastName = "Rojas", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 26, Goals = 0, Assist = 0, TeamId = 48 },

// Defenders
new { Id = 1062, FirstName = "Gustavo", LastName = "Gómez", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1063, FirstName = "Fabián", LastName = "Balbuena", ShirtNumber = "2", Position = PositionEnum.CenterBack, Age = 34, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1064, FirstName = "Junior", LastName = "Alonso", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 32, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1065, FirstName = "Iván", LastName = "Ramírez", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 30, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1066, FirstName = "Júnior", LastName = "Rojas", ShirtNumber = "6", Position = PositionEnum.LeftBack, Age = 27, Goals = 0, Assist = 0, TeamId = 48 },

// Midfielders
new { Id = 1067, FirstName = "Andrés", LastName = "Cubas", ShirtNumber = "14", Position = PositionEnum.DefendCenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1068, FirstName = "Mathías", LastName = "Villasanti", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1069, FirstName = "Richard", LastName = "Ortiz", ShirtNumber = "15", Position = PositionEnum.CenterMidfilder, Age = 34, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1070, FirstName = "Diego", LastName = "Gómez", ShirtNumber = "16", Position = PositionEnum.AttackingMidfilder, Age = 22, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1071, FirstName = "Miguel", LastName = "Almirón", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 31, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1072, FirstName = "Ramón", LastName = "Sosa", ShirtNumber = "11", Position = PositionEnum.LeftWinger, Age = 25, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1073, FirstName = "Matías", LastName = "Rojas", ShirtNumber = "17", Position = PositionEnum.RightWinger, Age = 29, Goals = 0, Assist = 0, TeamId = 48 },

// Forwards
new { Id = 1074, FirstName = "Antonio", LastName = "Sanabria", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 29, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1075, FirstName = "Adam", LastName = "Bareiro", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 28, Goals = 0, Assist = 0, TeamId = 48 },
new { Id = 1076, FirstName = "Gabriel", LastName = "Ávalos", ShirtNumber = "19", Position = PositionEnum.CenterForward, Age = 34, Goals = 0, Assist = 0, TeamId = 48 }

);

        builder.HasData(

// Goalkeepers
new { Id = 1077, FirstName = "Max", LastName = "Crocombe", ShirtNumber = "1", Position = PositionEnum.GoalKeeper, Age = 32, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1078, FirstName = "Oliver", LastName = "Sail", ShirtNumber = "12", Position = PositionEnum.GoalKeeper, Age = 29, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1079, FirstName = "Alex", LastName = "Paulsen", ShirtNumber = "23", Position = PositionEnum.GoalKeeper, Age = 22, Goals = 0, Assist = 0, TeamId = 44 },

// Defenders
new { Id = 1080, FirstName = "Winston", LastName = "Reid", ShirtNumber = "4", Position = PositionEnum.CenterBack, Age = 37, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1081, FirstName = "Michael", LastName = "Boxall", ShirtNumber = "5", Position = PositionEnum.CenterBack, Age = 36, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1082, FirstName = "Tommy", LastName = "Smith", ShirtNumber = "3", Position = PositionEnum.CenterBack, Age = 33, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1083, FirstName = "Liberato", LastName = "Cacace", ShirtNumber = "2", Position = PositionEnum.LeftBack, Age = 24, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1084, FirstName = "Tim", LastName = "Payne", ShirtNumber = "13", Position = PositionEnum.RightBAck, Age = 31, Goals = 0, Assist = 0, TeamId = 44 },

// Midfielders
new { Id = 1085, FirstName = "Joe", LastName = "Bell", ShirtNumber = "6", Position = PositionEnum.DefendCenterMidfilder, Age = 25, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1086, FirstName = "Marko", LastName = "Stamenic", ShirtNumber = "8", Position = PositionEnum.CenterMidfilder, Age = 23, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1087, FirstName = "Alex", LastName = "Rufer", ShirtNumber = "10", Position = PositionEnum.AttackingMidfilder, Age = 29, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1088, FirstName = "Matthew", LastName = "Garbett", ShirtNumber = "11", Position = PositionEnum.RightWinger, Age = 23, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1089, FirstName = "Callum", LastName = "McCowatt", ShirtNumber = "7", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1090, FirstName = "Clayton", LastName = "Lewis", ShirtNumber = "14", Position = PositionEnum.CenterMidfilder, Age = 27, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1091, FirstName = "Joe", LastName = "Champness", ShirtNumber = "15", Position = PositionEnum.AttackingMidfilder, Age = 28, Goals = 0, Assist = 0, TeamId = 44 },

// Forwards
new { Id = 1092, FirstName = "Chris", LastName = "Wood", ShirtNumber = "9", Position = PositionEnum.CenterForward, Age = 34, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1093, FirstName = "Ben", LastName = "Waine", ShirtNumber = "18", Position = PositionEnum.CenterForward, Age = 24, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1094, FirstName = "Kosta", LastName = "Barbarouses", ShirtNumber = "19", Position = PositionEnum.RightWinger, Age = 35, Goals = 0, Assist = 0, TeamId = 44 },
new { Id = 1095, FirstName = "Logan", LastName = "Rogerson", ShirtNumber = "20", Position = PositionEnum.LeftWinger, Age = 26, Goals = 0, Assist = 0, TeamId = 44 }

);








    }
}
