using Ex4._1Employes_Solution;

namespace TestProjetEmploye
{
    public class TestsEmployes
    {
        private Employe employe = new Employe("1234567", "Dupont", "Jean", new DateTime(1980, 5, 15), 50000.50, new DateTime(2005, 6, 1));

        [Fact]
        public void TestAge()
        {
            // Act
            int age = employe.Age();

            // Assert
            Assert.Equal(DateTime.Now.Year - 1980 - (DateTime.Now.DayOfYear < new DateTime(1980, 5, 15).DayOfYear ? 1 : 0), age);
        }

        [Fact]
        public void TestAnciennete()
        {
            // Act
            int anciennete = employe.Anciennete();

            // Assert
            Assert.Equal(DateTime.Now.Year - 2005 - (DateTime.Now.DayOfYear < new DateTime(2005, 6, 1).DayOfYear ? 1 : 0), anciennete);
        }

        [Fact]
        public void TestDroitStationnement()
        {
            // Act
            bool droit = employe.DroitStationnement();

            // Assert
            Assert.True(droit);
        }

        [Fact]
        public void TestMatricule()
        {
            // Act
            employe.Matricule = "7654321";

            // Assert
            Assert.Equal("7654321", employe.Matricule);
        }

        [Fact]
        public void TestNom()
        {
            // Act
            employe.Nom = "Martin";

            // Assert
            Assert.Equal("Martin", employe.Nom);
        }

        [Fact]
        public void TestPrenom()
        {
            // Act
            employe.Prenom = "Sophie";

            // Assert
            Assert.Equal("Sophie", employe.Prenom);
        }

        [Fact]
        public void TestSalaireAnnuel()
        {
            // Act
            employe.SalaireAnnuel = 60000.75;

            // Assert
            Assert.Equal(60000.75, employe.SalaireAnnuel);
        }

    }
}