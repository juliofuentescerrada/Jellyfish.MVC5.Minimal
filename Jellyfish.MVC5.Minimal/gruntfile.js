/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {

    grunt.initConfig({
        sass : {
            dist: {
                files: {
                    'styles/main.css': 'styles/scss/main.scss'
                }
            }
        },
        cssmin: {
            target: {
                files: [
                    {
                        expand: true,
                        src: 'styles/main.css',
                        ext: '.min.css'
                    }
                ]
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-sass');
    grunt.loadNpmTasks('grunt-contrib-cssmin');

    grunt.registerTask('bundle-css', ['sass', 'cssmin']);
};