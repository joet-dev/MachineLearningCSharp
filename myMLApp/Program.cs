using MyMLApp;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = "This restaurant sucked."
};

var result = SentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "positive" : "negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}"); 