function getExtension(path) {
    var basename = path.split(/[\\/]/).pop(),
        pos = basename.lastIndexOf(".");

    if (basename === "" || pos < 1)
        return "";

    return basename.slice(pos + 1);
}

jQuery.validator.addMethod("fileSize",
    function (value, element, params) {
        var fileSize = element.files[0].size / 1024 / 1024;
        var maxFileSize = $(element).attr("filesize") / 1024;
        return maxFileSize >= fileSize;
    });

jQuery.validator.addMethod("fileImage",
    function (value, element, params) {
        var fileType = getExtension(value.toLowerCase());
        if (fileType === "png" || fileType === "jpg" || fileType === "jpeg" ||
            fileType === "bmp" || fileType === "svg" || fileType === "gif" ||
            fileType === "tiff" || fileType === "webp" || fileType === "ico" || fileType === "pjpeg")
            return true;
        else
            return false;
    });

jQuery.validator.addMethod("fileType",
    function (value, element, params) {
        var fileType = getExtension(value.toLowerCase());
        var acceptType = $(element).attr("fileType");
        if (fileType === acceptType)
            return true;
        else
            return false;
    });

jQuery.validator.unobtrusive.adapters.addBool("fileType");
jQuery.validator.unobtrusive.adapters.addBool("fileSize");
jQuery.validator.unobtrusive.adapters.addBool("fileImage");