using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.Tests
{
    [TestClass]
    public class DeveloppeurAccessTests
    {
        private DeveloppeurAccess dal;

        [TestInitialize]
        public void Setup()
        {
            dal = new DeveloppeurAccess();
        }

        [TestMethod]
        public void GetLesDeveloppeurs_NoFilter_EqualsRawCount()
        {
            // 1) Exécution brute du COUNT(*) via ReqSelect
            var rows = Access
                .GetInstance()
                .Manager
                .ReqSelect("SELECT COUNT(*) FROM developpeur", null);
            // rows est une List<object[]> ; la première ligne, premier champ est notre COUNT
            int expectedTotal = Convert.ToInt32(rows[0][0]);

            // 2) Appel de la méthode DAL sans filtre
            List<Developpeur> liste = dal.GetLesDeveloppeurs(null);

            // 3) Assertion
            Assert.AreEqual(
                expectedTotal,
                liste.Count,
                $"On attend {expectedTotal} devs sans filtre, " +
                $"mais GetLesDeveloppeurs(null) en a retourné {liste.Count}."
            );
        }

        [TestMethod]
        public void GetLesDeveloppeurs_WithFilter_EqualsRawCount()
        {
            const int profilId = 2; // choisissez un ID de profil qui existe

            // 1) Exécution brute du COUNT(*) filtré via ReqSelect
            var rows = Access
                .GetInstance()
                .Manager
                .ReqSelect(
                    "SELECT COUNT(*) FROM developpeur WHERE idprofil = @p",
                    new Dictionary<string, object> { ["@p"] = profilId }
                );
            int expectedCount = Convert.ToInt32(rows[0][0]);

            // 2) Appel de la méthode DAL avec filtre
            List<Developpeur> liste = dal.GetLesDeveloppeurs(profilId);

            // 3) Assertion
            Assert.AreEqual(
                expectedCount,
                liste.Count,
                $"On attend {expectedCount} devs pour le profil {profilId}, " +
                $"mais GetLesDeveloppeurs({profilId}) en a retourné {liste.Count}."
            );
        }
    }
}