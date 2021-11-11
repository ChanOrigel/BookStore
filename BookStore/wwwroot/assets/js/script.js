/*
Author       : Dreamguys
Template Name: Docucare - Bootstrap Admin Template
Version      : 1.3
*/

(function ($) {
    "use strict";

    // Variables declarations

    var $wrapper = $('.main-wrapper');
    var $pageWrapper = $('.page-wrapper');
    var $slimScrolls = $('.slimscroll');
    var myModal = $('#ImageModal');
    // Sidebar

    var Sidemenu = function () {
        this.$menuItem = $('#sidebar-menu a');
    };

    function init() {
        var $this = Sidemenu;
        $('#sidebar-menu a').on('click', function (e) {
            if ($(this).parent().hasClass('submenu')) {
                e.preventDefault();
            }
            if (!$(this).hasClass('subdrop')) {
                $('ul', $(this).parents('ul:first')).slideUp(350);
                $('a', $(this).parents('ul:first')).removeClass('subdrop');
                $(this).next('ul').slideDown(350);
                $(this).addClass('subdrop');
            } else if ($(this).hasClass('subdrop')) {
                $(this).removeClass('subdrop');
                $(this).next('ul').slideUp(350);
            }
        });
        $('#sidebar-menu ul li.submenu a.active').parents('li:last').children('a:first').addClass('active').trigger('click');
    }

    // Sidebar Initiate
    init();

    // Mobile menu sidebar overlay

    $('body').append('<div class="sidebar-overlay"></div>');
    $(document).on('click', '#mobile_btn', function () {
        $wrapper.toggleClass('slide-nav');
        $('.sidebar-overlay').toggleClass('opened');
        $('html').addClass('menu-opened');
        return false;
    });

    // Sidebar overlay

    $(".sidebar-overlay").on("click", function () {
        $wrapper.removeClass('slide-nav');
        $(".sidebar-overlay").removeClass("opened");
        $('html').removeClass('menu-opened');
    });

    // Page Content Height

    if ($('.page-wrapper').length > 0) {
        var height = $(window).height();
        $(".page-wrapper").css("min-height", height);
    }

    // Page Content Height Resize

    $(window).resize(function () {
        if ($('.page-wrapper').length > 0) {
            var height = $(window).height();
            $(".page-wrapper").css("min-height", height);
        }
    });

    // Select 2

    if ($('.select').length > 0) {
        $('.select').select2({
            minimumResultsForSearch: -1,
            width: '100%'
        });
    }

    // Datetimepicker

    if ($('.datetimepicker').length > 0) {
        $('.datetimepicker').datetimepicker({
            format: 'DD/MM/YYYY',
            icons: {
                up: "fa fa-angle-up",
                down: "fa fa-angle-down",
                next: 'fa fa-angle-right',
                previous: 'fa fa-angle-left'
            }
        });
        $('.datetimepicker').on('dp.show', function () {
            $(this).closest('.table-responsive').removeClass('table-responsive').addClass('temp');
        }).on('dp.hide', function () {
            $(this).closest('.temp').addClass('table-responsive').removeClass('temp')
        });
    }

    // Tooltip

    if ($('[data-toggle="tooltip"]').length > 0) {
        $('[data-toggle="tooltip"]').tooltip();
    }

    // Datatable

    if ($('#Products-Table').length > 0) {
        $('#Products-Table').DataTable({
            "scrollX": true,
            paginate: true,
            searching: true,
            "ordering": true,
            "info": false,
            "language": {
                "paginate": {
                    "previous": "<span class='Prev-Next'><i class='fas fa-chevron-left'></span>",
                    "next": "<span class='Prev-Next'><i class='fas fa-chevron-right'></i></span>"
                }
            },
        });
        // $('.Table-Lerna').children('label').append('<button type="button" class="SearchButton "><img src="Libraries/icons/search-blue.svg" class="SearchButton" /> </button>');
        $('.dataTables_filter').children('label').append('<button type="button" class="SearchButton "><i class="fas fa-search"></i></button>');
    }
    if ($('.Table-Sections').length > 0) {
        $('.Table-Sections').DataTable({
            "scrollX": true,
            paginate: false,
            searching: false,
            "ordering": false,
            "info": false,
        });
    }

    if ($('.Table-Sizes').length > 0) {
        $('.Table-Sizes').DataTable({
            "scrollX": true,
            paginate: false,
            searching: false,
            "ordering": false,
            "info": false,
            "columnDefs": [
                {
                    "targets": [1, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22],
                    "visible": false,
                }
            ]
        });

    }
    if ($('#ArtDocument-Table').length > 0) {
        $('#ArtDocument-Table').DataTable({
            "scrollX": true,
            paginate: false,
            searching: false,
            // rowId: 'ArtDocId',
            "ordering": false,
            "info": false,
            //"columnDefs": [
            //    {
            //        "targets": [3, 10],
            //        "visible": false,
            //    }
            //]
        });
    }

    if ($('#Ingredients-Table').length > 0) {
        $('#Ingredients-Table').DataTable({
            "scrollX": true,
            paginate: false,
            searching: false,
            // rowId: 'ArtDocId',
            "ordering": false,
            "info": false,
            "columnDefs": [
                {
                    "targets": [2, 3],
                    "visible": false,
                }
            ]
        });
    }

    /*
     * Form Image - Dropzone
     * "upload.php" is not included with the template. You should create your own server side file to upload the files. 
     * See https://www.dropzonejs.com/#server-side-implementation for more information
     *
     */
    var initializeDropzone = function () {
        $('#dropzone-form-image').dropzone({
            url: '/Products/Upload',
            autoProcessQueue: false,
            paramName: "file",
            uploadMultiple: false,
            addRemoveLinks: true,
            acceptedFiles: ".png,.jpg,.gif,.bmp,.jpeg",// .pdf use this to restrict file type
            init: function () {
                var self = this;
                self.options.addRemoveLinks = true;
                self.options.dictRemoveFile = "Delete";
                //New file added
                self.on("addedfile", function (file) {
                    console.log('new file added ', file);
                    $('.dz-success-mark').hide();
                    $('.dz-error-mark').hide();

                    var id = $('#ShowImageTypeList').children('select').find(":selected").val();
                    $('#TypeId').val(id);
                    console.log(id);
                    $('#NewImage').val(file.name);
                    $('#ImageLoaded').val(file.name);
                    $('#ProductId-Modal').val($('#ProductID').val());
                    $('#ImageModal').modal('show');

                });
                //// Send file starts
                //self.on("sending", function (file) {
                //    console.log('upload started', file);
                //    $('.meter').show();
                //});
                // File upload Progress
                self.on("totaluploadprogress", function (progress) {
                    console.log("progress ", progress);
                    $('.roller').width(progress + '%');
                });
                self.on("queuecomplete", function (progress) {
                    $('.meter').delay(999).slideUp(999);
                });

                // On removing file
                self.on("removedfile", function (file) {
                    console.log(file);
                });

               
            }
        }).addClass('dropzone initialized');


    }
    var initializeDropzoneDesigner = function () {
        $('#dropzone-designerUpload-image').dropzone({
            url: '/Products/UploadImages',
            autoProcessQueue: false,
            paramName: "file",
            addRemoveLinks: true,
            uploadMultiple: true,
            parallelUploads: 100,
            acceptedFiles: ".png,.jpg,.gif,.bmp,.jpeg",// .pdf use this to restrict file type
            init: function () {
                var self = this;
                //New file added
                self.on("addedfile", function (file) {
                    console.log('new file added ', file);

                    $('.dz-success-mark').hide();
                    $('.dz-error-mark').hide();

                    var id = $('#ProductID').val();

                    $.ajax({
                        url: "/Products/UploadImagestest",
                        data: { files: JSON.stringify(file), uniqueProductId: id },
                        type: "POST",
                        cache: false,
                        async: true,
                        success: function (data) {
                            Swal.fire({
                                type: 'success',
                                title: "se guardo",
                                confirmButtonClass: 'btn btn-danger mt-2'
                            });
                        }
                    });

                });
                //// Send file starts
                self.on("sending", function (file) {
                    console.log('upload started', file);
                    $('.meter').show();
                });
                // File upload Progress
                self.on("totaluploadprogress", function (progress) {
                    console.log("progress ", progress);
                    $('.roller').width(progress + '%');
                });
                self.on("queuecomplete", function (progress) {
                    $('.meter').delay(999).slideUp(999);
                });

                // On removing file
                self.on("removedfile", function (file) {
                    myDropzone.removeFile(file);
                });
            }
        }).addClass('dropzone initialized');
    }
    
    // First Load
    $(document).ready(function () {
        if ($('#dropzone-form-image').get(0)) {
            initializeDropzone();
        }
        if ($('#dropzone-designerUpload-image').get(0)) {
            initializeDropzoneDesigner();
        }

       
    });

    // Sidebar Overlay Form Show
    $(window).on('ecommerce.sidebar.overlay.show', function () {
        if ($('#dropzone-form-image').get(0)) {
            initializeDropzone();
        }
        if ($('#dropzone-modal-image').get(0)) {
            initializeDropzone();
        }

        if ($('#dropzone-designerUpload-image').get(0)) {
            initializeDropzoneDesigner();
        }
        //if ($('#dropzone-designerUpload-image').get(0)) {
        //    initializeDropzoneDesigner();
        //}
    });


    // Email Inbox

    if ($('.clickable-row').length > 0) {
        $(document).on('click', '.clickable-row', function () {
            window.location = $(this).data("href");
        });
    }

    // Check all email

    $(document).on('click', '#check_all', function () {
        $('.checkmail').click();
        return false;
    });
    if ($('.checkmail').length > 0) {
        $('.checkmail').each(function () {
            $(this).on('click', function () {
                if ($(this).closest('tr').hasClass('checked')) {
                    $(this).closest('tr').removeClass('checked');
                } else {
                    $(this).closest('tr').addClass('checked');
                }
            });
        });
    }

    // Mail important

    $(document).on('click', '.mail-important', function () {
        $(this).find('i.fa').toggleClass('fa-star').toggleClass('fa-star-o');
    });

    // Summernote

    if ($('.summernote').length > 0) {
        $('.summernote').summernote({
            height: 200,                 // set editor height
            minHeight: null,             // set minimum height of editor
            maxHeight: null,             // set maximum height of editor
            focus: false                 // set focus to editable area after initializing summernote
        });
    }

    // Product thumb images

    if ($('.proimage-thumb li a').length > 0) {
        var full_image = $(this).attr("href");
        $(".proimage-thumb li a").click(function () {
            full_image = $(this).attr("href");
            $(".pro-image img").attr("src", full_image);
            $(".pro-image img").parent().attr("href", full_image);
            return false;
        });
    }

    // Lightgallery

    if ($('#pro_popup').length > 0) {
        $('#pro_popup').lightGallery({
            thumbnail: true,
            selector: 'a'
        });
    }

    // Sidebar Slimscroll

    if ($slimScrolls.length > 0) {
        $slimScrolls.slimScroll({
            height: 'auto',
            width: '100%',
            position: 'right',
            size: '7px',
            color: '#ccc',
            allowPageScroll: false,
            wheelStep: 10,
            touchScrollStep: 100
        });
        var wHeight = $(window).height() - 60;
        $slimScrolls.height(wHeight);
        $('.sidebar .slimScrollDiv').height(wHeight);
        $(window).resize(function () {
            var rHeight = $(window).height() - 60;
            $slimScrolls.height(rHeight);
            $('.sidebar .slimScrollDiv').height(rHeight);
        });
    }

    // Small Sidebar

    $(document).on('click', '#toggle_btn', function () {
        if ($('body').hasClass('mini-sidebar')) {
            $('body').removeClass('mini-sidebar');
            $('.subdrop + ul').slideDown();
        } else {
            $('body').addClass('mini-sidebar');
            $('.subdrop + ul').slideUp();
        }
        setTimeout(function () {
            mA.redraw();
            mL.redraw();
        }, 300);
        return false;
    });
    // $(document).on('mouseover', function(e) {
    // 	e.stopPropagation();
    // 	if($('body').hasClass('mini-sidebar') && $('#toggle_btn').is(':visible')) {
    // 		var targ = $(e.target).closest('.sidebar').length;
    // 		if(targ) {
    // 			$('body').addClass('expand-menu');
    // 			$('.subdrop + ul').slideDown();
    // 		} else {
    // 			$('body').removeClass('expand-menu');
    // 			$('.subdrop + ul').slideUp();
    // 		}
    // 		return false;
    // 	}
    // });

    // Full Screen
    $(".fullscreen-button").on("click", function toggleFullScreen() {
        $('html').addClass('fullscreen-button');
        if ((document.fullScreenElement !== undefined && document.fullScreenElement === null) || (document.msFullscreenElement !== undefined && document.msFullscreenElement === null) || (document.mozFullScreen !== undefined && !document.mozFullScreen) || (document.webkitIsFullScreen !== undefined && !document.webkitIsFullScreen)) {
            if (document.documentElement.requestFullScreen) {
                document.documentElement.requestFullScreen();
            } else if (document.documentElement.mozRequestFullScreen) {
                document.documentElement.mozRequestFullScreen();
            } else if (document.documentElement.webkitRequestFullScreen) {
                document.documentElement.webkitRequestFullScreen(Element.ALLOW_KEYBOARD_INPUT);
            } else if (document.documentElement.msRequestFullscreen) {
                document.documentElement.msRequestFullscreen();
            }
        } else {
            $('html').removeClass('fullscreen-button');
            if (document.cancelFullScreen) {
                document.cancelFullScreen();
                $('body').addClass('dark-horizontal');
            } else if (document.mozCancelFullScreen) {
                document.mozCancelFullScreen();
            } else if (document.webkitCancelFullScreen) {
                document.webkitCancelFullScreen();
            } else if (document.msExitFullscreen) {
                document.msExitFullscreen();
            }
        }
    });

    // Circle Progress Bar

    function animateElements() {
        $('.circle-bar1').each(function () {
            var elementPos = $(this).offset().top;
            var topOfWindow = $(window).scrollTop();
            var percent = $(this).find('.circle-graph1').attr('data-percent');
            var animate = $(this).data('animate');
            if (elementPos < topOfWindow + $(window).height() - 30 && !animate) {
                $(this).data('animate', true);
                $(this).find('.circle-graph1').circleProgress({
                    value: percent / 100,
                    size: 400,
                    thickness: 30,
                    fill: {
                        color: '#203a74'
                    }
                });
            }
        });
    }

    if ($('.circle-bar').length > 0) {
        animateElements();
    }
    $(window).scroll(animateElements);



})(jQuery);

// Table features
//Remove row
function Remove(row) {
    var name = $(row).parents('table').attr('id');

    var t = $('#' + name).DataTable();

    var tableRow = t.row($(row).parents('tr'));

    t.row(tableRow).remove().draw(false);

}
//Edit row
function Edit(row, Table='', LangId=0, TextId=0) {
    var h = $(row).parents('td').siblings('.Desc').text();


    if (LangId > 0) {
        $('#LangId-' + Table).val(LangId);
        $('#ShowLanguageList-'+Table).children('select').find('option[value="' + LangId + '"]').prop('selected', true);
    }
    if (TextId > 0) {
        $('#' + Table + '-TextId').val(TextId);
    }

    $('.DescriptionBox-' + Table).val(h);
    $('#' + Table + '-Id').val($(row).attr('id'));
    $('.Edit-' + Table).show();
    $('.New-' + Table).hide();
    $('.Cancel-' + Table).show();

    Validate("data", "TextData-" + Table);


}
function Cancel(Table = '') {
    $('#LangId-' + Table).val("1");
    $('#ShowLanguageList-'+Table).children('select').find('option[value="1"]').prop('selected', true);
    $('.DescriptionBox-' + Table).val("");
    $('#' + Table + '-TextId').val("");
    //$('#' + Table + '-Id').val("");
    $('.Edit-' + Table).hide();
    $('.New-' + Table).show();
    $('.Cancel-' + Table).hide();

    Validate("data", "TextData-" + Table);

}
//Add row
$('#AddIngredient').on('click', function () {

    var t = $('#Ingredients-Table').DataTable();
    var ing = $('#ShowIngredientList').children('select').find(":selected").text();
    var ingid = $('#ShowIngredientList').children('select').find(":selected").val();
    var eff = $('#ShowEfficacyList').children('select').find(":selected").text();
    var effId = $('#ShowEfficacyList').children('select').find(":selected").val();

    t.row.add([
        ing,
        eff,
        ingid,
        effId,
        '<button class="btn TextOrange" onclick="Remove(this)" ><i class="fas fa-trash-alt"></i></button>'
    ]).draw(false);

    Validate("data", "T-ActIng");
});


$('#AddPackage').on('click', function () {

    var t = $('#Package-Table').DataTable();
    var cont = $('#ShowContainerList').children('select').find(":selected").text();
    var contId = $('#ShowContainerList').children('select').find(":selected").val();
    var bar = $('#Barcode').val();

    var wmm = $('#Widthmm').val();
    var win = $('#Widthin').val();
    var w = wmm + "  |  " + win;

    var hmm = $('#Heightmm').val();
    var hin = $('#Heightin').val();
    var h = hmm + "  |  " + hin;

    var demm = $('#Depthmm').val();
    var dein = $('#Depthin').val();
    var de = demm + "  |  " + dein;

    var dimm = $('#Diammm').val();
    var diin = $('#Diamin').val();

    var vmm = $('#Volmm3').val();
    var voz = $('#Voloz').val();
    var vl = $('#Voll').val();
    var vgl = $('#Volgl').val();

    var qty = $('#Qty').val();

    var box = $('#BoxesLayer').val();
    var layer = $('#Layers').val();
    var bl = box + "  |  " + layer;


    t.row.add([
        cont,
        contId,
        bar,
        w,
        h,
        de,
        qty,
        bl,
        '<button class="btn TextOrange" onclick="Remove(this)" ><i class="fas fa-trash-alt"></i></button>',
        wmm,  //Width mm 9
        win,  //Width in
        hmm,  //Height mm
        hin,  //Height in
        demm,  //Depth mm
        dein,  //Depth in
        dimm,  //Diam mm
        diin,  //Diam in
        vmm,  //Vol mm3
        voz,  //Vol oz
        vl,  //Vol L
        vgl,  //Vol gl
        box,  //Boxes per layer
        layer,  //No of layers
    ]).draw(false);

    Validate("data", "T-Package");

});

//$('#AddDocument').on('click', function () {

//    var t = $('#Document-Table').DataTable();
//    var doc = $('#DocType option:selected').text();
//    var ver = $('#Version').val();
//    var pdf = $('#FilePDF').text();
//    var date = $('#ExpDate').val();

//    t.row.add([
//        pdf,
//        doc,
//        ver,
//        date,
//        '<button class="btn TextOrange" onclick="Remove(this)" ><i class="fas fa-trash-alt"></i></button>'
//    ]).draw(false);

//});

//$('#AddArtDocument').on('click', function () {

//    var t = $('#ArtDocument-Table').DataTable();
//    var cont = $('#DocType option:selected').text();
//    var ver = $('#Version').val();
//    var prod = $('#ProdNumber').val();
//    var ups = $('#NoUps').val();
//    var lang = $('#NoLang').val();
//    var pdf = $('#FilePDF').text();
//    var Colors = $('#Colors').val();


//    t.row.add([

//        '<input type="checkbox" name="Verified"/>',
//        cont,
//        prod,
//        Colors,
//        ver,
//        ups,
//        lang,
//        '<div class="calicon uploadIconTable"></div><input class="form-control fileLoad SignedDoc" type="file">',
//        '<button class="btn" style="color: #E00900;" onclick="Download(this)" ><i class="far fa-file-pdf"></i></button>',
//        '<button class="btn TextOrange" onclick="Remove(this)" ><i class="fas fa-trash-alt"></i></button>',
//        pdf
//    ]).draw(false);

//});


function Verify(Artwork) {

    $('.ModalTittle').text('Verify');
    $('.ModalBodyTittle').show();
    $('.ModalBodySubTittle').show();
    $('.DocSignModal').hide();

    $('.ReturnModal').text('Cancel');
    $('.AcceptModal').show();
    $('.SubmitModal').hide();

    $(Artwork).prop('checked', false);

    ////FALTA HACER DISABLE EL CHECKBOX CUANDO SE VERIFICA CON EL YES
    //// $(Artwork).attr("disabled", true);



    //var row = $(Artwork).clone();

    //var t = $('#ArtDocument-Table').DataTable();
    //var tableRow = t.row($(Artwork).parents('tr'));
    //// console.log(t.data().count());

    //$('#Aux').html(row);

}
function SignedDoc(Artwork) {
    $('.ModalTittle').text('Signed Document');
    $('.ModalBodyTittle').hide();
    $('.ModalBodySubTittle').hide();
    $('.DocSignModal').show();

    $('.ReturnModal').text('Go back');
    $('.AcceptModal').hide();
    $('.SubmitModal').show();

}






////////////////////////////////settings language
function Listchanges(e) {
    var name = $(e).parents('div').attr('id');
    console.log(name);

    if (name.includes("MainList")) {
        var mainId =$('#' + name).children('select').find(':selected').val();
        var cut = name.replace("MainList-", "");
        ShowMainTable(cut, mainId);
        $('#Main-' + cut + '-Id').val(mainId);
        $('#' + cut + '-Id').val(mainId); //this is for the text section
        console.log(mainId, cut);
    }

    if (name.includes("ShowLanguageList")) {
        var lang = $('#' + name).children('select').find(':selected').val();

        var cut = name.replace("ShowLanguageList-", "");
        $('#LangId-' + cut).val(lang);
    }

    if (name.includes("ShowRoleList")) {
        var roleId = $('#' + name).children('select').find(':selected').val();
        $('#RoleID').val(roleId);

    }
    if (name.includes("ShowImageTypeList")) {
        var TypeId = $('#' + name).children('select').find(':selected').val();
        $('#TypeId').val(TypeId);

    }
    if (name.includes("ShowDocumentList")) {
        var TypeId = $('#' + name).children('select').find(':selected').val();
        $('#DocumentTypeId').val(TypeId);

    }
    if (name.includes("ShowContainerList")) {
        var TypeId = $('#' + name).children('select').find(':selected').val();
        $('#ContainerTypeId').val(TypeId);

    }
    if (name.includes("ProductList")) {
        var TypeId = $('#' + name).children('select').find(':selected').val();
        $('#ProductId').val(TypeId);

    }
}


function NewMain(Table) {

    $('.NewMain-' + Table).hide();
    $('.EditMain-' + Table).hide();
    $('.CancelMain-' + Table).show();
    $('.SaveMain-' + Table).show();
    $('.ArchiveMain-' + Table).hide();

    $('.Main-' + Table).show();
    $('#MainList-' + Table).hide();
    $('#' + Table + '-Tab').hide();

    //clean the main id 
    $('#Main-' + Table + '-Id').val("");
    $('#MainDesc-' + Table).val("");

}
function EditMain(Table) {
    //init text to edit
    var main = $('#MainList-' + Table).children('select').find(':selected').text();
    var mainid = $('#MainList-' + Table).children('select').find(':selected').val();
    $('#MainDesc-' + Table).val(main);
    $('#Main-' + Table + '-Id').val(mainid);


    $('.NewMain-' + Table).hide();
    $('.EditMain-' + Table).hide();
    $('.CancelMain-' + Table).show();
    $('.SaveMain-' + Table).show();
    $('.ArchiveMain-' + Table).hide();

    $('.Main-' + Table).show();
    $('#MainList-' + Table).hide();
    $('#' + Table + '-Tab').hide();

   
}


function CancelMain(Table) {

    $('.NewMain-' + Table).show();
    $('.EditMain-' + Table).show();
    $('.CancelMain-' + Table).hide();
    $('.SaveMain-' + Table).hide();
    $('.ArchiveMain-' + Table).show();

    $('.Main-' + Table).hide();
    $('#MainList-' + Table).show();
    $('#' + Table + '-Tab').show();

    Validate("data", "Main-" + Table);


}
