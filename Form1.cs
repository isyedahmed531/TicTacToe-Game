using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {

        classTicTacToe obj = new classTicTacToe();
        public TicTacToe()
        {
            InitializeComponent();
        }
 
        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }
        //
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnOne.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else 
            {
                this.btnOne.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }
            this.btnOne.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnTwo.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnTwo.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnTwo.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnThree.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnThree.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnThree.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnFour.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnFour.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnFour.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnFive.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnFive.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnFive.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }


        private void btnSix_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnSix.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnSix.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnSix.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnSeven.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnSeven.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnSeven.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnEight.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnEight.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnEight.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue());
            checkForWinner();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (obj.getToogleValue())
            {
                this.btnNine.Text = obj.getUserOne();
                this.lblPlaterStatus.Text = "Playing: Player 2";
            }
            else
            {
                this.btnNine.Text = obj.getUserTwo();
                this.lblPlaterStatus.Text = "Playing: Player 1";
            }

            this.btnNine.Enabled = false;
            obj.setToogleValue(!obj.getToogleValue()); 
            checkForWinner();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.btnOne.Text = null;
            this.btnTwo.Text = null;
            this.btnThree.Text = null;
            this.btnFour.Text = null;
            this.btnFive.Text = null;
            this.btnSix.Text = null;
            this.btnSeven.Text = null;
            this.btnEight.Text = null;
            this.btnNine.Text = null;
            //
            this.btnOne.Enabled = true;
            this.btnTwo.Enabled = true;
            this.btnThree.Enabled = true;
            this.btnFour.Enabled = true;
            this.btnFive.Enabled = true;
            this.btnSix.Enabled = true;
            this.btnSeven.Enabled = true;
            this.btnEight.Enabled = true;
            this.btnNine.Enabled = true;
            //
            this.lblPlaterStatus.Text = "Playing: Player 1";
        }
        private void checkForWinner()
        {
            if (this.btnOne.Text == "O" && this.btnTwo.Text == "O" && this.btnThree.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnOne.Text == "O" && this.btnFive.Text == "O" && this.btnNine.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnOne.Text == "O" && this.btnFour.Text == "O" && this.btnSeven.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnTwo.Text == "O" && this.btnFive.Text == "O" && this.btnEight.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnThree.Text == "O" && this.btnSix.Text == "O" && this.btnNine.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnThree.Text == "O" && this.btnFive.Text == "O" && this.btnSeven.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnFour.Text == "O" && this.btnFive.Text == "O" && this.btnSix.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            if (this.btnSeven.Text == "O" && this.btnEight.Text == "O" && this.btnNine.Text == "O")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 1";
                checkWinning();
            }
            //
            if (this.btnOne.Text == "X" && this.btnTwo.Text == "X" && this.btnThree.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnOne.Text == "X" && this.btnFive.Text == "X" && this.btnNine.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnOne.Text == "X" && this.btnFour.Text == "X" && this.btnSeven.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnTwo.Text == "X" && this.btnFive.Text == "X" && this.btnEight.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnThree.Text == "X" && this.btnSix.Text == "X" && this.btnNine.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnThree.Text == "X" && this.btnFive.Text == "X" && this.btnSeven.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnFour.Text == "X" && this.btnFive.Text == "X" && this.btnSix.Text == "x")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
            if (this.btnSeven.Text == "X" && this.btnEight.Text == "X" && this.btnNine.Text == "X")
            {
                this.lblPlaterStatus.Text = "Winner: PLAYER 2";
                checkWinning();
            }
        }
        private void checkWinning() {
            this.btnOne.Enabled = false;
            this.btnTwo.Enabled = false;
            this.btnThree.Enabled = false;
            this.btnFour.Enabled = false;
            this.btnFive.Enabled = false;
            this.btnSix.Enabled = false;
            this.btnSeven.Enabled = false;
            this.btnEight.Enabled = false;
            this.btnNine.Enabled = false;
        }
        /*private void matchDrawStatus() {
            if (!checkForWinner()) {
                this.lblPlaterStatus.Text = "Match Draw";
            }
        }*/

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
    class classTicTacToe {
        bool toogleValue = true;
        String userOne = "O";
        String userTwo = "X";
        public void setToogleValue(bool toogleValue)
        {
            this.toogleValue = toogleValue;
        }
        public bool getToogleValue()
        {
            return this.toogleValue;
        }
        public void setUserOne(String userOne)
        {
            this.userOne = userOne;
        }
        public String getUserOne()
        {
            return userOne;
        }
        public void setUserTwo(String userTwo)
        {
            this.userTwo = userTwo;
        }
        public String getUserTwo()
        {
            return userTwo;
        }        
    }
}