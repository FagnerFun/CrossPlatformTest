using CrossPlatformTest.UITest.Base;
using System;
using TechTalk.SpecFlow;

namespace CrossPlatformTest.UITest
{
    [Binding]
    [Scope(Feature = "LoginRequirements")]
    public class LoginSteps
    {
        [Given(@"an user at login screen")]
        public void LoginScreenIsDisplayed()
        {
            Global.App.WaitForElement(x => x.Marked("LOGIN"), "Não foi possivel localizar a tela de login", TimeSpan.FromMinutes(1));
            Global.App.Screenshot("Login screen");
        }

        [Given(@"inform mail '(.*)'")]
        public void InformUser(string mail)
        {
            Global.App.EnterText(x => x.Marked("UsernameEntry"), mail);
        }

        [Given(@"inform password '(.*)'")]
        public void InformPassword(string password)
        {
            Global.App.EnterText(x => x.Marked("PasswordEntry"), password);
        }

        [When(@"he press login button")]
        public void PressLoginButton()
        {
            Global.App.Tap(x => x.Marked("LoginButton"));
        }

        [Then(@"he user seen products screen")]
        public void OrderScreenIsDisplayed()
        {
            Global.App.WaitForElement(X => X.Marked("Mobile phone"), "Não foi possivel localizar a tela de produtos", TimeSpan.FromMinutes(1));
            Global.App.Screenshot("products");
        }

        [Then(@"he user seen error message")]
        public void ErrorMessageIsDisplayed()
        {
            Global.App.WaitForElement(X => X.Marked("Login Failed."), "Não foi possivel localizar a tela de produtos", TimeSpan.FromMinutes(1));
            Global.App.Screenshot("error message");
        }
    }
}
