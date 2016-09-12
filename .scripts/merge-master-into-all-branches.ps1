cd "$PSScriptRoot\.."

$branches = git for-each-ref refs/remotes/origin --format='%(refname)' | `
		foreach {	$_ -replace "refs/remotes/origin/", ""}
$branches | `
		foreach { 
		  $branch = $_
			Write-Host "merging master into $branch..."
			git checkout $branch
			git pull
			git merge master
			if (-not $?) { 
				Write-Host "An error occured. Solve it, then rerun this script." 
				break		
			}
		}

git checkout master