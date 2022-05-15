namespace KarenLogic {
  public class Store {
    private Karen karen;
    private bool containsOwner;

    public Store(Karen karen) {
      this.karen = karen;
    }

    public void ActivateTheKaren() {
      karen.Appear();
    }

    public void OwnerWalksIn() {
      containsOwner = true;
    }

    public void ResetOwner() {
      containsOwner = false;
    }

        public void Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.Damage(1);
            }
        }
      public void button1Update(){
       if (karen.IsPresent && containsOwner)
           {
              karen.button1Damage(1);
           }
      }

        public void button2Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.button2Damage(1);
            }
        }

        public void button3Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.button3Damage(1);
            }
        }

        public void button4Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.button4Damage(1);
            }
        }

        public void button5Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.button5Damage(1);
            }
        }
    }
}
