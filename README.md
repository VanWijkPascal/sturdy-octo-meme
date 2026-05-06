"# sturdy-octo-meme" 

1) using github to create a repo, then pushing a txt file gives an "access denied" error
1. probly accout login related
1. have not found where to resolve that yet in visual studio

2) added a file "appconfig.json" to test the
add to gitIrnore, and the file dissapears from your pc next pull
outcome: the file cannot be opened by Visual Studio (even after being create there) but Visual Code sees it just fine

ran "git rm --cached appconfig.json on my machine to remove the file form the index, and github told me "file conflict, index deleted"
so it did, now to see whether or not it worked