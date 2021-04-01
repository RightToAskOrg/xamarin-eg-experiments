using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ElectionGuard;
using SDK = ElectionGuard;

namespace HelloEGWorld2
{
    public partial class MainPage : ContentPage
    {
        // ulong[] rValue;
        // ulong[] rValue = new ulong[] { 0, 0 };
        // ElementModP r;

        public MainPage()
        {
            // ulong[] rValue = new ulong[] { 0, 0 };
            // r = new ElementModP(rValue);

            InitializeComponent();
        }

        void Yes_Ballot_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            PlaintextBallot plaintext = Make_Yes_Ballot();
            ((Button)sender).Text = $"Yes-vote created!";
        }

        void No_Ballot_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            PlaintextBallot plaintext = Make_No_Ballot();
            ((Button)sender).Text = $"No-vote created!";
        }

        void Encrypt_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var nonce = Constants.ONE_MOD_Q;

            // Don't use this secret key except for silly tests.
            var secretKey = Constants.TWO_MOD_Q;
            var keyPair = ElGamalKeyPair.FromSecret(secretKey);
            var publicKey = keyPair.PublicKey;
            ulong vote = 1;

            var ciphertext = Elgamal.Encrypt(vote, nonce, publicKey);
            // var plaintext = ciphertext.Decrypt(keyPair.SecretKey);

            ((Button)sender).Text = $"I encrypted a vote.  Maybe even the one you asked for.";

        }

        private PlaintextBallot Make_Yes_Ballot()
        {
            string data = @"{""ballot_style"":""ballot-style-1"",""contests"":[{""ballot_selections"":[{""object_id"":""contest-1-yes-selection-id"",""vote"":1},{""object_id"":""contest-1-no-selection-id"",""vote"":0}],""object_id"":""contest-1-id""},{""ballot_selections"":[{""object_id"":""contest-2-selection-1-id"",""vote"":1},{""object_id"":""contest-2-selection-2-id"",""vote"":0}],""object_id"":""contest-2-id""}],""object_id"":""ballot-id-123""}"; ;

            PlaintextBallot plaintext = new PlaintextBallot(data);

            return plaintext;
        }

        private PlaintextBallot Make_No_Ballot()
        {
            string data = @"{""ballot_style"":""ballot-style-1"",""contests"":[{""ballot_selections"":[{""object_id"":""contest-1-yes-selection-id"",""vote"":0},{""object_id"":""contest-1-no-selection-id"",""vote"":1}],""object_id"":""contest-1-id""},{""ballot_selections"":[{""object_id"":""contest-2-selection-1-id"",""vote"":1},{""object_id"":""contest-2-selection-2-id"",""vote"":0}],""object_id"":""contest-2-id""}],""object_id"":""ballot-id-123""}"; ;

            PlaintextBallot plaintext = new PlaintextBallot(data);

            return plaintext;
        }
    }
}
