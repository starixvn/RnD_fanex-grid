
var site =
    {
        cachedDOM:
            {
                parentMenu: null
            },
        registerEvents: function () {
            site.cachedDOM.parentMenu
                .off('click.grid')
                .on('click.grid', function () {
                    var $this = $(this);
                    if ($this.data('hide-child')) {
                        $this.next().show(500);
                        $this.data('hide-child', false)
                        .find('glyphicon').removeClass('glyphicon-plus').addClass('glyphicon-minus');
                    }
                    else {
                        $this.next().hide(500);
                        $this.data('hide-child', true)
                        .find('glyphicon').removeClass('glyphicon-minus').addClass('glyphicon-plus');
                    }
                });
        },
        initialize: function () {
            site.cachedDOM.parentMenu = $('.list-menu-header');

            site.registerEvents();
        }
    };

$(function () {
    site.initialize();
})