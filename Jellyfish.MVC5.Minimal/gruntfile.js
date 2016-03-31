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
        },
        uglify: {
            target : {
                files : {
                    'scripts/main.min.js' : ['scripts/main.js']
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-sass');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');

    grunt.registerTask('bundle-css', ['sass', 'cssmin']);
    grunt.registerTask('bundle-js', ['uglify']);
};