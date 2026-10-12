string aliceQuote = (
            "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing " +
            "to do: once or twice she had peeped into the book her sister was reading, but it had no pictures " +
            "or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or " +
            "conversation?’"
        );

        Console.WriteLine("=== Alice's Adventures in Wonderland Search Tool ===");
        Console.Write("Enter a word or phrase to search: ");
        string searchTerm = Console.ReadLine();

        string aliceLowerQuote = aliceQuote.ToLowerInvariant();

        // STEP 3: INTENTIONAL BUG ADDED HERE
        // Bug: Calling .ToLowerInvariant() directly on `searchTerm` without checking if it is null.
        // If a user pipes an empty stream or if ReadLine returns null, this line throws a NullReferenceException.
        bool foundTerm = aliceLowerQuote.Contains(searchTerm.ToLowerInvariant());

        Console.WriteLine($"It is {foundTerm} that the term '{searchTerm}' is within the quote.");
    }
}