# Greg.Xrm
[![Build Status](https://neronotte.visualstudio.com/Greg.Xrm/_apis/build/status/neronotte.Greg.Xrm?branchName=master)](https://neronotte.visualstudio.com/Greg.Xrm/_build/latest?definitionId=2&branchName=master)

A suite of [XrmToolBox](https://www.xrmtoolbox.com/) tools to overcome D365 feature gaps.

## _n.EnvironmentComparer
**Environment comparer** is a tool that simplifies the comparison between different environments.

MORE INFO SOON

## _n.SolutionManager
**Solution manager** is a tool that provides an intuitive, easy to use, UI on the solution import process.
When connected to an environment, it shows the **last importjob** with the following info:

- Solution uniquename
- Solution friendlyname
- Solution version
- Solution publisher
- Solution description
- Import percentage of completeness (with a progressbar)
- Import output logs (with warnings and errors)

It provides the following capabilities

- autorefresh
- search by CTRL+F / F3
- enriched output log view via treeview


# Wishlist

- Introduzione di un help in linea
- Possibilit� di eseguire confronti parziali (solo su un subset di entit� della lista)
- Possibilit� di visualizzare il json di configurazione e modificarlo a mano (con validazione)
- Possibilit� di cambiare le connessioni (CRM1 e CRM2 direttamente dentro il tool)
- Evitare di introdurre in coda action diverse per lo stesso record
- Possibilit� di monitorare il processo di uninstall delle solution.

## Releases

You can download the tool using the [Release page](https://github.com/neronotte/Greg.Xrm/releases) or NuGet:

- [_n.EnvironmentComparer](https://www.nuget.org/packages/Greg.Xrm.EnvironmentComparer)
- [_n.SolutionManager](https://www.nuget.org/packages/Greg.Xrm.SolutionManager)