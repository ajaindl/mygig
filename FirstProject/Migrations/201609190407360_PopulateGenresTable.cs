namespace FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Country')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Rock')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Jazz')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Classical')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in (1,2,3,4) ");
        }
    }
}
