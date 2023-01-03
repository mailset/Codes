<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'WordPress' );

/** Database username */
define( 'DB_USER', 'mail_set' );

/** Database password */
define( 'DB_PASSWORD', '114wMaIl@SeTs514' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         '-@+CZ3M:6_6LhU`xl@:w_$zP?;=9`gZC(w_Mv]&znKV{6p/IN(,_dch<zR7a57_h' );
define( 'SECURE_AUTH_KEY',  'p44dz7,N(:k0*?u9O>?of3I-DzMO8@HIe2i97X2*FFY}]HC37Hg%IJtMxjaf+V4t' );
define( 'LOGGED_IN_KEY',    ',jIx1)W;Vn}bNY[v{;259$*f;|O?qRxz3DEPs[CuJ wE{@/.LpJF,ZFt;rG97{?]' );
define( 'NONCE_KEY',        'Udb:t?xTyTA3} |{4xUD$KF`rk{quL(>*EQ&)?qM%u!5|+epe7*ORwEA0HSO.[ 2' );
define( 'AUTH_SALT',        'fMam#3,eVqob~_,%puuq@D0QVPk1b_J#t[ nkxO:W}]0<Au/qO.W^pAmV]5tX<H]' );
define( 'SECURE_AUTH_SALT', 'LM&fF8+R6==xe:})aOgQ+CIt=p!w(2:eCWAs9s?zrcO&msHPou;gf~kH/H$mT}1|' );
define( 'LOGGED_IN_SALT',   '?F<(CHS(J:$SjY{t;We@eXt-9t0_`88@$#0n;70Z@e7(1dRC+k)Tp44^My!8ur1/' );
define( 'NONCE_SALT',       '(8#]=-&^m^lgY-/^pg~1x&KBp0[c{i ezV}FA4[!HGWlE(q5GfsKU<[Zp7+N|1} ' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
