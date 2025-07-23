namespace VSM.Client.Datamodel
{

    class DataModel
    {
        // Private static variable that holds the single instance
        private static readonly Lazy<DataModel> _instance = new Lazy<DataModel>(() => new DataModel());

        // Prevent instantiation from outside
        private DataModel() { }

        // Public static property to access the instance
        public static DataModel Instance { get { return _instance.Value; } }

        User? logged_in_user;
        RootFolder? selected_root_folder;

        public User? GetLoggedInUser() { return logged_in_user; }
        public User? PerformUserLogIn(string initials)
        {
            // validate user by creating af single sign on.
            // this is a placeholder for the real authentication logic.
            // if the log in work, then creata a User object and return true
            logged_in_user = new User(initials);
            return GetLoggedInUser();
        }

        public void SetRootFolder(RootFolder rootFolder)
        {
            selected_root_folder = rootFolder;
        }
        public RootFolder? GetRootFolder()
        {
            return selected_root_folder;
        }

        private static List<RootFolder> rootFolders = new();
        public List<RootFolder> GetRootFoldersForUser()
        {
            User? user = GetLoggedInUser();
            // this is a placeholder for the real logic to get the root folders for a user.
            // in a real application, this would query a database or an API.
            if (user is null)
            {
                rootFolders.Clear();
                return rootFolders;
            }

            if (rootFolders.Count == 0)
            {

                int rootId = 1;
                rootFolders.Add(
                    new RootFolder
                    {
                        Id = rootId,
                        Users = new List<User> { user },
                        root_path = "\\\\domain.net\\root_1"
                    });

                rootFolders.Add(
                    new RootFolder
                    {
                        Id = ++rootId,
                        Users = new List<User> { user },
                        root_path = "\\\\domain.net\\root_2"
                    });

            }
            return rootFolders;
        }

        private static List<RootFolder> un_registered_rootFolders = new();
        public List<RootFolder> GetUnRegisteredRootFolders()
        {
            User? user = GetLoggedInUser();

            if (user is null)
            {
                return new List<RootFolder>();
            }

            if (un_registered_rootFolders.Count == 0)
            {

                int rootId = 3;
                un_registered_rootFolders.Add(
                    new RootFolder
                    {
                        Id = rootId,
                        Users = new List<User> { user },
                        root_path = "\\\\domain.net\\root_3"
                    });

                un_registered_rootFolders.Add(
                    new RootFolder
                    {
                        Id = ++rootId,
                        Users = new List<User> { user },
                        root_path = "\\\\domain.net\\root_4"
                    });

            }
            return un_registered_rootFolders;
        }

        public bool RegisterRootFolder(RootFolder rootFolder)
        {
            if (GetLoggedInUser() is null)
            {
                return false;
            }
            List<RootFolder> registered_root_folders = GetRootFoldersForUser();
            //ignore if the root folder is already registered.
            if (registered_root_folders.Any(r => r.root_path == rootFolder.root_path))
            {
                return false;
            }

            registered_root_folders.Add(rootFolder);
            un_registered_rootFolders.RemoveAll(r => r.Id == rootFolder.Id);
            return true;
        }

        //return the folder hierarchy that match the path to the rootfolder.
        public Folder GenerateFolderTreeForRootFolder(RootFolder root)
        {

            int idCounter = 1;
            Folder the_root_folder = new Folder
            {
                Id = idCounter,
                ParentId = idCounter,
                Name = root.root_path,
                IsExpanded = true,
                Level = 0,
                Attributs = AttributeRow.GenerateAttributeRow(idCounter),
                Attributs2 = AttributeRow2.GenerateAttributeRow(idCounter),
            };

            idCounter = the_root_folder.Id;

            //generate 10 children under the root folder
            for (int r = 1; r < 10; r++)
            {
                Folder parent = the_root_folder;

                //generate one child pr level
                for (int level = 1; level <= 3; level++)
                {
                    var childId = ++idCounter;
                    var child = new Folder
                    {
                        Id = childId,
                        ParentId = parent.Id,
                        Name = $"Node {r}.{level}",
                        //IsExpanded = true,
                        Level = level,
                        Attributs = AttributeRow.GenerateAttributeRow(childId),
                        Attributs2 = AttributeRow2.GenerateAttributeRow(childId),
                    };

                    parent.Children.Add(child);

                    parent = child; // for the newt level 
                }
            }
            return the_root_folder;
        }

    }

}