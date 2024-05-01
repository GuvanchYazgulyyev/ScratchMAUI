namespace ScratchMAUI.ViewModel
{
    [QueryProperty(nameof(Fact), nameof(Fact))]
    public partial class FactDetailViewModel : ObservableObject
    {
        private readonly ITextToSpeech _textToSpeech;
        [ObservableProperty]
        private FactModel _fact;

        public FactDetailViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
        }
        [RelayCommand]
        private async Task SpeakFactAsync()
        {
            // Türkçe dilini kullanacak şekilde dil ayarını yapın
            var options = new SpeechOptions
            {
                Pitch = 1 // Opsiyonel: Telaffuz ayarlarını isteğe bağlı olarak ayarlayın
            };

            // Metin içerisinde Türkçe karakterler varsa, doğru işlenebilmesi için gerekli kodlamayı sağlayın
            string turkishFact = ConvertToTurkishText(Fact.Fact);

            // Metni okutma işlemini gerçekleştirin
            await _textToSpeech.SpeakAsync(turkishFact, options);
        }

        // Türkçe metinlerdeki özel karakterlerin doğru işlenmesi için gerekli kodlamayı sağlayan bir yardımcı fonksiyon
        private string ConvertToTurkishText(string text)
        {
            // Örnek dönüşüm: İngilizce "Istanbul" -> Türkçe "İstanbul"
            text = text.Replace("I", "İ");

            // Daha fazla özel karakter dönüşümü yapabilirsiniz

            return text;
        }

        [RelayCommand]
        private async Task CopyFactAsync()
        {
            await Clipboard.Default.SetTextAsync($"{Fact.Fact} - {Fact.CategoryName} | Scratch by Guvanch Yazgulyyev Prince");
        }


    }
}
