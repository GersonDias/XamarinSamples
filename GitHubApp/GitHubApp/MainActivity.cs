using System;
using Android.App;
using Android.Widget;
using Android.OS;
using System.Linq;

namespace GitHubApp
{
    [Activity(Label = "GitHubApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            var btnSearch = FindViewById<Button>(Resource.Id.btnSearch2);

            var txtUser = FindViewById<EditText>(Resource.Id.txtUser);

            var lvwRepositories = FindViewById<ListView>(Resource.Id.lvwRepositories);

            btnSearch.Click += async (object sender, EventArgs e) =>
            {
                var gitHub = new Shared.GitHubApi();
                var repos = await gitHub.GetAsync(txtUser.Text);

                lvwRepositories.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, repos.ToList());
            };
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {


        }
    }
}

