cd "$PSScriptRoot\.."

$branches = git for-each-ref refs/remotes/origin --format='%(refname)' | `
		foreach {	$_ -replace "refs/remotes/origin/", ""}
$branches | `
		foreach { 
		  $branch = $_
			Write-Host "creating local branch to track $branch..."
			git branch --track $_ "origin/$branch"
		}