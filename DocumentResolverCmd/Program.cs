using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MWL.DocumentResolver;

namespace DocumentResolverCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useWordStemmer = true; // use the word stemmer with all resolvers
            string outputfile = @"ResolverOutput.txt";
            System.IO.File.Delete(outputfile);

            // Output sample results for one document against each resolver
            ResolveDocument(useWordStemmer, outputfile, @"DictionaryData5000.txt", "Three new Queensland fishes 1922 Ogilby, J D");

            // Output times for each resolver to process a list against dictionaries of various sizes.
            ResolveList(useWordStemmer, outputfile, @"DictionaryData250.txt", @"DocumentData100.txt");
            ResolveList(useWordStemmer, outputfile, @"DictionaryData1000.txt", @"DocumentData100.txt");
            ResolveList(useWordStemmer, outputfile, @"DictionaryData5000.txt", @"DocumentData100.txt");
        }

        private static void ResolveDocument(bool useWordStemmer, string outputfile, string dictionaryfile, string document)
        {
            // Initalize instances of all of the resolvers that will be tested
            DocumentResolver documentResolver = new DocumentResolver();
            BayesResolverEngine bayesResolver = new BayesResolverEngine();
            LevenshteinResolverEngine levenshteinResolver = new LevenshteinResolverEngine();
            TFIDFResolverEngine tfidfResolver = new TFIDFResolverEngine();

            // Load the dictionary into all of the resolvers
            Dictionary<string, string> dictionary = LoadData(dictionaryfile);
            documentResolver.SetDictionary(dictionary);
            bayesResolver.Dictionary = dictionary;
            levenshteinResolver.Dictionary = dictionary;
            tfidfResolver.Dictionary = dictionary;

            // Process all 100 documents with each resolver, recording the time 
            // each resolver takes to complete the task.
            System.IO.File.AppendAllText(outputfile,
                string.Format("Processing '{0}' against a dictionary with {1} entries.\r\n",
                document,
                dictionary.Count()));

            System.IO.File.AppendAllText(outputfile, "\r\nBayes/TFIDF\r\n");
            documentResolver.SetEngine(DocumentResolver.EngineType.BayesTFIDF);
            List<ResolutionResult> resolutionResults = documentResolver.Resolve(document, useWordStemmer);
            foreach (ResolutionResult resolutionResult in resolutionResults)
            {
                System.IO.File.AppendAllText(outputfile, string.Format("{0} {1} {2}\r\n", resolutionResult.Score.ToString(), resolutionResult.Key, resolutionResult.Document));
            }

            System.IO.File.AppendAllText(outputfile, "\r\nBayes/Levenshtein\r\n");
            documentResolver.SetEngine(DocumentResolver.EngineType.BayesLevenshtein);
            resolutionResults = documentResolver.Resolve(document, useWordStemmer);
            foreach (ResolutionResult resolutionResult in resolutionResults)
            {
                System.IO.File.AppendAllText(outputfile, string.Format("{0} {1} {2}\r\n", resolutionResult.Score.ToString(), resolutionResult.Key, resolutionResult.Document));
            }

            System.IO.File.AppendAllText(outputfile, "\r\nBayes\r\n");
            resolutionResults = bayesResolver.Resolve(document, useWordStemmer);
            foreach (ResolutionResult resolutionResult in resolutionResults)
            {
                System.IO.File.AppendAllText(outputfile, string.Format("{0} {1} {2}\r\n", resolutionResult.Score.ToString(), resolutionResult.Key, resolutionResult.Document));
            }

            System.IO.File.AppendAllText(outputfile, "\r\nLevenshtein\r\n");
            resolutionResults = levenshteinResolver.Resolve(document, useWordStemmer);
            foreach (ResolutionResult resolutionResult in resolutionResults)
            {
                System.IO.File.AppendAllText(outputfile, string.Format("{0} {1} {2}\r\n", resolutionResult.Score.ToString(), resolutionResult.Key, resolutionResult.Document));
            }

            System.IO.File.AppendAllText(outputfile, "\r\nTFIDF\r\n");
            resolutionResults = tfidfResolver.Resolve(document, useWordStemmer);
            foreach (ResolutionResult resolutionResult in resolutionResults)
            {
                System.IO.File.AppendAllText(outputfile, string.Format("{0} {1} {2}\r\n", resolutionResult.Score.ToString(), resolutionResult.Key, resolutionResult.Document));
            }

            System.IO.File.AppendAllText(outputfile, "\r\n\r\n");
        }

        private static void ResolveList(bool useWordStemmer, string outputfile, string dictionaryfile, string inputfile)
        {
            // Initalize instances of all of the resolvers that will be tested
            DocumentResolver documentResolver = new DocumentResolver();
            BayesResolverEngine bayesResolver = new BayesResolverEngine();
            LevenshteinResolverEngine levenshteinResolver = new LevenshteinResolverEngine();
            TFIDFResolverEngine tfidfResolver = new TFIDFResolverEngine();

            // Load the dictionary into all of the resolvers
            Dictionary<string, string> dictionary = LoadData(dictionaryfile);
            documentResolver.SetDictionary(dictionary);
            bayesResolver.Dictionary = dictionary;
            levenshteinResolver.Dictionary = dictionary;
            tfidfResolver.Dictionary = dictionary;

            // Load the data to be resolved
            Dictionary<string, string> documents = LoadData(inputfile);

            // Process all 100 documents with each resolver, recording the time 
            // each resolver takes to complete the task.
            System.IO.File.AppendAllText(outputfile, 
                string.Format("Processing {0} documents against a dictionary with {1} entries.\r\n\r\n", 
                documents.Count(),
                dictionary.Count()));

            documentResolver.SetEngine(DocumentResolver.EngineType.BayesTFIDF);
            DateTime startTime = DateTime.Now;
            foreach (KeyValuePair<string, string> document in documents)
            {
                documentResolver.Resolve(document.Value, useWordStemmer);
            }
            DateTime endTime = DateTime.Now;
            System.IO.File.AppendAllText(outputfile, string.Format("Bayes/TFIDF processing complete.  {0} seconds elapsed.\r\n", (endTime - startTime).TotalSeconds.ToString()));

            documentResolver.SetEngine(DocumentResolver.EngineType.BayesLevenshtein);
            startTime = DateTime.Now;
            foreach (KeyValuePair<string, string> document in documents)
            {
                documentResolver.Resolve(document.Value, useWordStemmer);
            }
            endTime = DateTime.Now;
            System.IO.File.AppendAllText(outputfile, string.Format("Bayes/Levenshtein processing complete.  {0} seconds elapsed.\r\n", (endTime - startTime).TotalSeconds.ToString()));

            startTime = DateTime.Now;
            foreach (KeyValuePair<string, string> document in documents)
            {
                bayesResolver.Resolve(document.Value, useWordStemmer);
            }
            endTime = DateTime.Now;
            System.IO.File.AppendAllText(outputfile, string.Format("Bayes processing complete.  {0} seconds elapsed.\r\n", (endTime - startTime).TotalSeconds.ToString()));

            startTime = DateTime.Now;
            foreach (KeyValuePair<string, string> document in documents)
            {
                levenshteinResolver.Resolve(document.Value, useWordStemmer);
            }
            endTime = DateTime.Now;
            System.IO.File.AppendAllText(outputfile, string.Format("Levenshtein processing complete.  {0} seconds elapsed.\r\n", (endTime - startTime).TotalSeconds.ToString()));

            startTime = DateTime.Now;
            foreach (KeyValuePair<string, string> document in documents)
            {
                tfidfResolver.Resolve(document.Value, useWordStemmer);
            }
            endTime = DateTime.Now;
            System.IO.File.AppendAllText(outputfile, string.Format("TFIDF processing complete.  {0} seconds elapsed.\r\n\r\n\r\n", (endTime - startTime).TotalSeconds.ToString()));
        }

        private static Dictionary<string, string> LoadData(string filename)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string[] documents = System.IO.File.ReadAllLines(filename);
            for (int i = 1; i < documents.Length; i++)
            {
                string[] docInfo = documents[i].Split('\t');
                string content = string.Format("{0} {1} {2}", docInfo[1], docInfo[2], docInfo[3].Replace(" | ", " "));
                data.Add(docInfo[0], content);
            }

            return data;
        }
    }
}
