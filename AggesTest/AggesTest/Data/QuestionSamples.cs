using AggesTest.Model;

namespace AggesTest.Data
{
    public static class QuestionSamples
    {
        public static List<Question> QuestionList { get; set; } = new();
        public static Question TempQuestion { get; set; }
        public static bool Ready { get; set; } = false;

        public static void FillQuestionList()
        {
            QuestionList.Add(new(1, "Åldersbegrepp i relation till mognad"));
            QuestionList.Add(new(2, "Neurovetenskap"));
            QuestionList.Add(new(3, "Sensoriskt minne"));
            QuestionList.Add(new(4, "Perception"));
            QuestionList.Add(new(5, "'Bottom-up' Nedifrån och upp"));
            QuestionList.Add(new(6, "'Top-Down' uppifrån och ned bearbetning"));
            QuestionList.Add(new(7, "Arbetsminnet"));
            QuestionList.Add(new(8, "Fonologiska loopen (arbetsminnet)"));
            QuestionList.Add(new(9, "Visuospatiella skissblocket"));
            QuestionList.Add(new(10, "Elaborering (elaborera till repetion)"));
            QuestionList.Add(new(11, "Chunking"));
            QuestionList.Add(new(12, "Kognitiv överbelastning"));
            QuestionList.Add(new(13, "Centrala exekutiva funktionen (arbetsminnet)"));
            QuestionList.Add(new(14, "Långtidsminne"));
            QuestionList.Add(new(15, "Procedurminne"));
            QuestionList.Add(new(16, "Deklarativt minne"));
            QuestionList.Add(new(17, "Engram"));
            QuestionList.Add(new(18, "Proveffekten"));
            QuestionList.Add(new(19, "Konsolidering"));
            QuestionList.Add(new(20, "Minnet rekonstruktivt"));
            QuestionList.Add(new(21, "Synaps"));
            QuestionList.Add(new(22, "Neuron"));
            QuestionList.Add(new(23, "Falska minnen"));
            QuestionList.Add(new(24, "Semantiskt minne"));
            QuestionList.Add(new(25, "Plasticitet"));
            QuestionList.Add(new(26, "Hjärnbarken"));
            QuestionList.Add(new(27, "Självbild"));
            QuestionList.Add(new(28, "Självkänsla"));
            QuestionList.Add(new(29, "'Self-efficiacy' Självtilltro (Bandura)"));
            QuestionList.Add(new(30, "Episodiskt minne"));
            QuestionList.Add(new(31, "Metakognition"));
            QuestionList.Add(new(32, "Kognition"));
            QuestionList.Add(new(33, "Objektpermanens (Piaget)"));
            QuestionList.Add(new(34, "Schema (Piaget)"));
            QuestionList.Add(new(35, "Ackommodation (Piaget)"));
            QuestionList.Add(new(36, "Assimilation (Piaget)"));
            QuestionList.Add(new(37, "Hjärnbalken"));
            QuestionList.Add(new(38, "Hjärnstam"));
            QuestionList.Add(new(39, "Orbital frontal cortex"));
            QuestionList.Add(new(40, "Pannlob / Frontallob"));
            QuestionList.Add(new(41, "Tinninglob"));
            QuestionList.Add(new(42, "Hjässlob"));
            QuestionList.Add(new(43, "Nacklob"));
            QuestionList.Add(new(44, "Lilla hjärnan"));
            QuestionList.Add(new(45, "Hjärnhalva / Hemisfär"));
            QuestionList.Add(new(46, "Piaget stadie 4/4 formellt - operationella stadiet"));
            QuestionList.Add(new(47, "Piaget stadie 3/4 konkret - operationella stadiet"));
            QuestionList.Add(new(48, "Piaget stadie 2/4 pre-operationella stadiet"));
            QuestionList.Add(new(49, "Piaget stadie 1/4 Det sensmotoriska stadiet"));
            QuestionList.Add(new(50, "Emotions reglering (känsloreglering)"));
            QuestionList.Add(new(51, "Emotion"));
            QuestionList.Add(new(52, "Den proximala utvecklingzonen"));
            QuestionList.Add(new(53, "Anknytningsteori"));
            QuestionList.Add(new(54, "Eriksson studie 4/8 Aktivitet kontra underlägsenhet"));
            QuestionList.Add(new(55, "Eriksson studie 3/8 Iniativ och skuld"));
            QuestionList.Add(new(56, "Eriksson studie 2/8 Anatomi och skuldkänsor/tvivel"));
            QuestionList.Add(new(57, "Eriksson studie 1/8 Tillit kontra misstro"));

            Ready = true;
        }

        public static void RandomQuestion()
        {
            if (Ready)
            {
                Random rnd = new Random();
                int randomint = rnd.Next(1, 57);
                TempQuestion = QuestionList.FirstOrDefault(x => x.Id == randomint);
            }
            else
            {
                RandomQuestion();
            }
           
        }
        
    }
}
