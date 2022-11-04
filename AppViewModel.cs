using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab2
{
    public class AppViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Numbers> Numbers { get; set; } = new ObservableCollection<Numbers>();

        private ObservableCollection<string> numHistory = new ObservableCollection<string>();
        public ReadOnlyObservableCollection<string> NumHistory { get; }
        public AppViewModel()
        {
            NumHistory = new ReadOnlyObservableCollection<string>(numHistory);
        }

        Random random = new Random();
        private int userCheckCounter = 0;
        private int buttonsAmount = 0;
        private int guessed = 0;
        private Command pickCell;

        public int AmountOfButtons
        {
            get => buttonsAmount;
            set
            {
                buttonsAmount = value;
                OnPropertyChanged("AmountContent");
            }
        }
        public int UserMoveCounter
        {
            get => userCheckCounter;
            set
            {
                userCheckCounter = value;
                OnPropertyChanged("UserMoveContent");
            }
        }
        public string AmountContent => Convert.ToString(buttonsAmount);

        public string UserMoveContent => Convert.ToString(userCheckCounter);

        public void NumbersButtonsCreate(int amount)
        {
            AmountOfButtons = 0;
            bool isTrueButton;
            int randomCreate;
            for (int i = 0; i < amount; i++)
            {
                randomCreate = random.Next(0, 20);
                if (randomCreate > 15){ 
                    isTrueButton = true;
                    AmountOfButtons++;
                }
                else
                    isTrueButton = false;
                Numbers.Add(new Numbers(isTrueButton, true, i + 1));
            }
        }

        private Command startGame;
        public Command StartGame
        {
            get
            {
                return startGame ?? (startGame = new Command(obj =>
                {
                    startingClear();
                    int amount;
                    if (int.TryParse(obj.ToString(), out amount))
                        if (amount < 41)
                            NumbersButtonsCreate(amount);
                        else
                            MessageBox.Show("Слишком большое число");
                    else MessageBox.Show("Ошибка");
                }
                    ));
            }
        }

        public Command PickCell
        {
            get
            {
                return pickCell ?? (pickCell = new Command(obj =>
                {
                    int btn = int.Parse(obj.ToString());
                    Numbers[(btn-1)].DeleteThisCell();

                    if (Numbers[(btn - 1)].Truefalse)
                    {
                        numHistory.Add((btn).ToString() + "👍");
                        guessed++;
                    }
                    else
                        numHistory.Add((btn).ToString());

                    winCheck(guessed);
                }));
            }
        }

        private void startingClear()
        {
            numHistory.Clear();
            Numbers.Clear();
            guessed = 0;
        }

        private void winCheck(int guessed)
        {
            if (guessed == AmountOfButtons)
                MessageBox.Show("ура победа");
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
