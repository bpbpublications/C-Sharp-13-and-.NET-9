Action<string> greet = (name) => {
    string greeting = $"Hello, {name}!";
    Console.WriteLine(greeting);
};

greet("World"); // Outputs: Hello, World!
