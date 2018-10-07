// I adapted these functions from Mozilla's es5 polyfill functions
if (!String.prototype.startsWith) {
	String.prototype.startsWith = function(textToSearch) {
        return (this.substr(0, textToSearch.length) === textToSearch);
    };
}

if(!String.prototype.endsWith) {
	String.prototype.endsWith = function(textToSearch) {
        return (this.substring(this.length - textToSearch.length, this.length) === textToSearch);
    }; 
}