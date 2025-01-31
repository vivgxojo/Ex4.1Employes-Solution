using Ex4._1Employes_Solution;

namespace TestProjetEmploye
{
    public class TestsEmployes
    {
        // Arrange
        private Employe employe = new Employe("1234567", "Dupont", "Jean", new DateTime(2000, 5, 15), 50000.50, new DateTime(2005, 6, 1));

        [Fact]
        public void TestAge()
        {
            // Act
            int age = employe.Age();

            // Assert
            Assert.Equal(24, age);
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
            Assert.False(droit);
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
        public void TestPrenomVide()
        {
            string message = "";
            // Act
            try
            {
                employe.Prenom = "";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            // Assert
            Assert.Equal(message, "Le prénom ne peut pas être vide.");
        }

        [Fact]
        public void TestSalaireAnnuel()
        {
            // Act
            employe.SalaireAnnuel = 60000.75;

            // Assert
            Assert.Equal(60000.75, employe.SalaireAnnuel);
        }

        [Fact]
        public void DateNaissance()
        {
            // Act
            employe.DateNaissance = new DateTime(2001, 5, 15);

            // Assert
            Assert.Equal(employe.DateNaissance, new DateTime(2001, 5, 15));
        }

    }
}