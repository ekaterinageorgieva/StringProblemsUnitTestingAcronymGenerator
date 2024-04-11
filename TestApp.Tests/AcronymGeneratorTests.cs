using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class AcronymGeneratorTests
{
    [Test]
    public void Test_GenerateAcronym_EmptyString_ReturnsEmptyString()
    {
        // Assert
        string acronym = string.Empty;

        // Act
        string result = AcronymGenerator.GenerateAcronym(acronym);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GenerateAcronym_SingleWord_ReturnsUpperCaseFirstLetter()
    {
        // Assert
        string acronym = "Bulgaria";

        // Act
        string result = AcronymGenerator.GenerateAcronym(acronym);

        // Assert
        Assert.That(result, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GenerateAcronym_MultipleWords_ReturnsUpperCaseFirstLetters()
    {
        // Assert
        string acronym = "united states of america";

        // Act
        string result = AcronymGenerator.GenerateAcronym(acronym);

        // Assert
        Assert.That(result, Is.EqualTo("USA"));
    }

    [Test]
    public void Test_GenerateAcronym_WordsWithNonLetters_ReturnsAcronymWithoutNonLetters()
    {
        // Assert
        string acronym = "Hello, World!";

        // Act
        string result = AcronymGenerator.GenerateAcronym(acronym);

        // Assert
        Assert.That(result, Is.EqualTo("HW"));
    }

    [Test]
    public void Test_GenerateAcronym_PhraseWithSpecialCharacters_ReturnsUpperCaseFirstLetters()
    {
        // Assert
        string acronym = "Primer for this, can it?";

        // Act
        string result = AcronymGenerator.GenerateAcronym(acronym);

        // Assert
        Assert.That(result, Is.EqualTo("PFTCI"));
    }
}
