using ShitHappens.FileManagement;
using ShitHappens.Logic;
using ShitHappens.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitHappens.Controller
{
    public class MainMenuController
    {
        private BaseForm view;
        public MainMenuController(MainMenuForm view)
        {
            this.view = view;
            this.view.SetController(this);
            this.view.Show();
        }
        public void NewGame()
        {
            try
            {
                var model = new Model();
                model.deck = FileReader.Read("shit_happens_data.csv");
                var controller = new StartParamsController(model, (StartParamsForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<StartParamsForm>()));
                this.view.Close();
            }catch(FileNotFoundException)
            {
                MessageBox.Show("Can't find file shit_happens_data.csv\nMake sure it's in the applications folder.", "Error");

            }
            catch (FormatException)
            {
                MessageBox.Show("Can't read data from file.\nMake sure data is in correct format.", "Error");
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void LoadGame()
        {
            try
            {
                var model = GameSaver.Load();
                var controller = new GameController(model, (GameForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<GameForm>()));
                this.view.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find file save.json\nMake sure it's in the applications folder.", "Error");

            }
            catch (FormatException)
            {
                MessageBox.Show("Can't read data from file.\nMake sure data is in correct format.", "Error");
            }
            catch (System.Text.Json.JsonException)
            {
                MessageBox.Show("Can't read data from file.\nMake sure data is in correct format.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        private void ChangeController(BaseForm view)
        {
            view.SetController(this);
            view.Show();
            this.view.Close();
            this.view = view;
        }
        public void HowToPlay()
        {
            var view = (HowToPlayForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<HowToPlayForm>());
            ChangeController(view);
        }
        public void MainMenu()
        {
            var view = (MainMenuForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<MainMenuForm>());
            ChangeController(view);
        }
    }
}
