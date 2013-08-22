DOCUMENTRESOLVER
================

The DocumentResolver project encapsulates several algorithms for resolving a document (text string) against a dictionary of documents (text string).  

The algorithms themselves are open source implementations found at the following locations:

Bayes Classifier: http://www.codeproject.com/Articles/14270/A-Naive-Bayesian-Classifier-in-C

Term Frequency - Inverse Document Frequency (TFIDF): http://www.codeproject.com/Articles/12098/Term-frequency-Inverse-document-frequency-implemen

Levenshtein Distance: http://www.codeproject.com/Articles/13525/Fast-memory-efficient-Levenshtein-algorithm

In the DocumentResolver project, the algorithms have been modified slightly, but are largely unchanged from their original forms.

Each algorithm returns scores indicating how similar the document being resolved is to each document in the dictionary.  The "best" score varies by the algorithm used for the document resolution.

Bayes: The documents in the dictionary that receive the highest score are the closest matches to the document being resolved.

Term Frequency - Inverse Document Frequency: Documents in the dictionary are assigned a score ranging from 0 to 1.  Scores closest to 1 are the closest matches to the document being resolved.

Levenshtein Distance: The documents in the dictionary that receive the lowest score (0 being "best") are the closest matches to the document being resolved.

The TFIDF and Levenshtein algorithms produce output that is suited to identifying a few "best" matches. The Bayes output is better suited for identifying matching sets of documents.

Unfortunately, both the TFIDF and Levenshtein algorithms perform slowly when a document is being compared to a large dictionary.  Because of this, using those algorithms to perform real-time resolution of more than a small number of documents is not feasible.  The Bayes algorithm handles large dictionaries much more efficiently, but is less specific about which document is the "best" match.  

Because of this, the DocumentResolver project also includes a class (DocumentResolver.cs) that resolves documents by combining the Bayes algorithm with either TFIDF or Levenshtein.  Documents being resolved are first analyzed with the Bayes Classifier algorithm to identify a subset of the dictionary that contains the most likely matches, and that subset is then analyzed with TFIDF or Levenshtein.  In this way, the number of documents that the TFIDF/Levenshtein algorithm has to process is limited to a number that can be processed quickly.

If the dictionary of documents to be analyzed is small (1000 documents or less), then any of the algorithms can be used effectively.  If the dictionary is large, it is recommended that either the Bayes-TFIDF or Bayes-Levenshtein combinations be used.


DOCUMENTRESOLVERGUI
===================

The DocumentResolverGUI project is a basic Windows Forms application that can be used to exercise the Bayes-TFIDF and Bayes-Levenshtein combinations.


DOCUMENTRESOLVERCMD
===================

The DocumentResolverCmd project is a Windows console application that provides an example of how to use all five (Bayes, TFIDF, Levenshtein, Bayes-TFIDF, and Bayes-Levenshtein) of the resolution algorithms.


