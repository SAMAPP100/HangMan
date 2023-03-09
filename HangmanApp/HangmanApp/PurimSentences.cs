namespace HangmanApp
{
    public class PurimSentences
    {
        public List<List<string>> AllSentences { get; set; }

        public PurimSentences()
        {
            // Initialize the list of sentences
            AllSentences = new List<List<string>>() {
             new List<string> { "Purim", "is", "a", "Jewish", "holiday." },
            new List<string> { "The", "holiday", "is", "celebrated", "in", "late", "February", "or", "early", "March." },
            new List<string> { "The", "Purim", "story", "is", "in", "the", "Book", "of", "Esther." },
            new List<string> { "Esther", "was", "a", "Jewish", "woman." },
            new List<string> { "Esther", "became", "the", "queen", "of", "Persia." },
            new List<string> { "Mordecai", "was", "Esther's", "cousin." },
            new List<string> { "Mordecai", "helped", "foil", "an", "assassination", "plot." },
            new List<string> { "Haman", "was", "a", "high-ranking", "official." },
            new List<string> { "Haman", "wanted", "to", "exterminate", "the", "Jewish", "people." },
            new List<string> { "Haman", "cast", "lots", "(purim)", "to", "determine", "the", "day", "of", "the", "massacre." },
            new List<string> { "Esther", "revealed", "her", "Jewish", "identity", "to", "the", "king." },
            new List<string> { "The", "king", "issued", "a", "decree", "to", "protect", "the", "Jews." },
            new List<string> { "Jews", "celebrate", "Purim", "by", "reading", "the", "Megillah." },
            new List<string> { "The", "Megillah", "is", "the", "Book", "of", "Esther." },
            new List<string> { "Jews", "dress", "up", "in", "costumes", "on", "Purim." },
            new List<string> { "Hamantaschen", "are", "triangle-shaped", "cookies." },
            new List<string> { "Hamantaschen", "are", "filled", "with", "poppy", "seeds", "or", "other", "sweet", "fillings." },
            new List<string> { "Jews", "give", "gifts", "of", "food", "and", "drink", "on", "Purim." },
            new List<string> { "Mishloach", "Manot", "is", "the", "Hebrew", "term", "for", "these", "gifts." },
            new List<string> { "Purim", "is", "a", "time", "of", "joy", "and", "celebration." },
            new List<string> { "Purim", "is", "one", "of", "the", "most", "festive", "Jewish", "holidays." },
            new List<string> { "Purim", "is", "a", "time", "for", "feasting", "and", "drinking." },
            new List<string> { "The", "Purim", "spiel", "is", "a", "traditional", "play", "performed", "on", "Purim." },
            new List<string> { "The", "Purim", "spiel", "often", "parodies", "the", "Purim", "story." },
            new List<string> { "Purim", "is", "also", "known", "as", "the", "Feast", "of", "Lots." },
            new List<string> { "The", "Feast", "of", "Lots", "refers", "to", "Haman's", "casting", "of", "lots." },
            new List<string> { "Purim", "is", "not", "a", "Biblical", "holiday." },
            new List<string> { "Purim", "is", "mentioned", "in", "the", "Talmud." },
            new List<string> { "The", "Talmud", "is", "a", "collection", "of", "Jewish", "oral", "traditions." },
            new List<string> { "The", "Purim", "story", "takes", "place", "in", "Persia." },
            new List<string> { "Purim", "is", "a", "time", "to", "remember", "the", "Jewish", "people's", "victory", "over", "their", "enemies." },
            new List<string> { "Purim", "is", "a", "time", "to", "celebrate", "the", "Jewish", "people's", "survival." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "plot", "to", "destroy", "the", "Jewish", "people." },
            new List<string> { "Purim", "is", "a", "time", "to", "give", "charity", "to", "the", "poor." },
            new List<string> { "Purim", "is", "celebrated", "by", "Jews", "all", "over", "the", "world." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "Jewish", "woman", "who", "becomes", "queen." },
            new List<string> { "Purim", "is", "a", "time", "to", "rejoice", "with", "friends", "and", "family." },
            new List<string> { "Purim", "is", "a", "time", "to", "dress", "up", "in", "costumes." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "Jewish", "man", "who", "saves", "the", "kingdom." },
            new List<string> { "Purim", "is", "a", "time", "to", "read", "the", "Book", "of", "Esther." },
            new List<string> { "The", "Book", "of", "Esther", "is", "a", "part", "of", "the", "Hebrew", "Bible." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "wicked", "advisor", "named", "Haman." },
            new List<string> { "Purim", "is", "a", "time", "to", "eat", "hamentashen." },
            new List<string> { "Hamentashen", "are", "triangular", "pastries", "with", "a", "sweet", "filling." },
            new List<string> { "Purim", "is", "a", "time", "to", "give", "gifts", "of", "food", "to", "friends." },
            new List<string> { "Purim", "is", "a", "time", "to", "exchange", "gifts", "with", "loved", "ones." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "Jewish", "man", "named", "Mordechai." },
            new List<string> { "Mordechai", "was", "Esther's", "uncle." },
            new List<string> { "Purim", "is", "a", "time", "to", "celebrate", "Jewish", "heritage", "and", "culture." },
            new List<string> { "Purim", "is", "a", "time", "to", "play", "games", "and", "have", "fun." },
            new List<string> { "The", "Purim", "story", "is", "about", "a", "Jewish", "woman", "named", "Esther." },
            new List<string> { "Esther", "was", "chosen", "to", "be", "the", "queen", "of", "Persia." },
            new List<string> { "Purim", "is", "a", "time", "to", "renew", "friendships", "and", "repair", "relationships." },
            new List<string> { "Purim", "is", "a", "time", "to", "connect", "with", "Jewish", "communities", "around", },
        };
        }

    }
}
