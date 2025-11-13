LogMessage("Salam salam", SimpleLogger);
LogMessage("Salam salam", TimeLogger);
LogMessage("Salam salam", UpperLogger);
LogMessage("Salam salam", FileLogger);
void LogMessage(string text, Logger logger)
{
    logger(text);
}
void SimpleLogger(string text)
{
    Console.WriteLine(text);
}
void TimeLogger(string text)
{
    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {text}");
}

void UpperLogger(string text)
{
    Console.WriteLine(text.ToUpper());
}

void FileLogger(string text)
{
    Console.WriteLine($"(Fayla yazıldı): {text}");
}

delegate void Logger(string text);