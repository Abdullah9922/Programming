import 'package:flutter/material.dart';
import 'package:supabase_flutter/supabase_flutter.dart';

const _supabaseUrl = 'https://zxhzxpbdufuziccgccxg.supabase.co';
const _supabaseKey = 'sb_publishable__vwSndgSPNJ_Z3vSd-4Wvg_YW0CLzAY';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await Supabase.initialize(url: _supabaseUrl, publishableKey: _supabaseKey);
  runApp(const CloudKitchenApp());
}

class CloudKitchenApp extends StatelessWidget {
  const CloudKitchenApp({super.key});
  @override
  Widget build(BuildContext context) => MaterialApp(
    debugShowCheckedModeBanner: false,
    title: 'Cloud Kitchen',
    theme: ThemeData(
      colorScheme: ColorScheme.fromSeed(seedColor: const Color(0xffd35400)),
      useMaterial3: true,
    ),
    home: const AuthGate(),
  );
}

class AuthGate extends StatelessWidget {
  const AuthGate({super.key});
  @override
  Widget build(BuildContext context) => StreamBuilder<AuthState>(
    stream: Supabase.instance.client.auth.onAuthStateChange,
    builder: (context, snapshot) {
      final session =
          snapshot.data?.session ??
          Supabase.instance.client.auth.currentSession;
      return session == null ? const LoginScreen() : const RoleRouter();
    },
  );
}

class LoginScreen extends StatefulWidget {
  const LoginScreen({super.key});
  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  final _email = TextEditingController();
  final _password = TextEditingController();
  bool _loading = false;

  Future<void> _login() async {
    if (_email.text.trim().isEmpty || _password.text.length < 6) {
      _show('Valid email and a 6+ character password are required.');
      return;
    }
    setState(() => _loading = true);
    try {
      await Supabase.instance.client.auth.signInWithPassword(
        email: _email.text.trim(),
        password: _password.text,
      );
    } on AuthException catch (error) {
      _show(error.message);
    } finally {
      if (mounted) setState(() => _loading = false);
    }
  }

  void _show(String message) => ScaffoldMessenger.of(
    context,
  ).showSnackBar(SnackBar(content: Text(message)));

  @override
  void dispose() {
    _email.dispose();
    _password.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => Scaffold(
    body: SafeArea(
      child: Center(
        child: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(24),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                const Icon(
                  Icons.restaurant_menu_rounded,
                  size: 86,
                  color: Color(0xffd35400),
                ),
                const SizedBox(height: 20),
                Text(
                  'Cloud Kitchen',
                  textAlign: TextAlign.center,
                  style: Theme.of(context).textTheme.headlineMedium?.copyWith(
                    fontWeight: FontWeight.bold,
                  ),
                ),
                const SizedBox(height: 8),
                const Text(
                  'Sign in to order, manage food, or deliver.',
                  textAlign: TextAlign.center,
                ),
                const SizedBox(height: 32),
                TextField(
                  controller: _email,
                  keyboardType: TextInputType.emailAddress,
                  decoration: const InputDecoration(
                    labelText: 'Email',
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 14),
                TextField(
                  controller: _password,
                  obscureText: true,
                  decoration: const InputDecoration(
                    labelText: 'Password',
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 20),
                FilledButton(
                  onPressed: _loading ? null : _login,
                  style: FilledButton.styleFrom(
                    minimumSize: const Size.fromHeight(52),
                  ),
                  child: Text(_loading ? 'Signing in...' : 'Sign in'),
                ),
                TextButton(
                  onPressed: _loading
                      ? null
                      : () => Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (_) => const SignupScreen(),
                          ),
                        ),
                  child: const Text('New here? Create an account'),
                ),
              ],
            ),
          ),
        ),
      ),
    ),
  );
}

class SignupScreen extends StatefulWidget {
  const SignupScreen({super.key});
  @override
  State<SignupScreen> createState() => _SignupScreenState();
}

class _SignupScreenState extends State<SignupScreen> {
  final _formKey = GlobalKey<FormState>();
  final _name = TextEditingController();
  final _phone = TextEditingController();
  final _address = TextEditingController();
  final _email = TextEditingController();
  final _password = TextEditingController();
  String _role = 'customer';
  bool _loading = false;
  @override
  void dispose() {
    for (final c in [_name, _phone, _address, _email, _password]) {
      c.dispose();
    }
    super.dispose();
  }

  Future<void> _signup() async {
    if (!_formKey.currentState!.validate()) return;
    setState(() => _loading = true);
    try {
      final response = await Supabase.instance.client.auth.signUp(
        email: _email.text.trim(),
        password: _password.text,
        data: {
          'name': _name.text.trim(),
          'phone': _phone.text.trim(),
          'address': _address.text.trim(),
          'role': _role,
        },
      );
      if (response.user != null && mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(
            content: Text(
              'Account created. Check email if confirmation is enabled.',
            ),
          ),
        );
      }
      if (mounted) {
        Navigator.pop(context);
      }
    } on AuthException catch (error) {
      if (mounted) {
        ScaffoldMessenger.of(
          context,
        ).showSnackBar(SnackBar(content: Text(error.message)));
      }
    } finally {
      if (mounted) setState(() => _loading = false);
    }
  }

  @override
  Widget build(BuildContext context) => Scaffold(
    appBar: AppBar(title: const Text('Create account')),
    body: SafeArea(
      child: Form(
        key: _formKey,
        child: ListView(
          padding: const EdgeInsets.all(20),
          children: [
            TextFormField(
              controller: _name,
              decoration: const InputDecoration(labelText: 'Full name'),
              validator: (v) =>
                  v == null || v.trim().isEmpty ? 'Name is required' : null,
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _phone,
              keyboardType: TextInputType.phone,
              decoration: const InputDecoration(labelText: 'Phone number'),
              validator: (v) =>
                  v == null || v.trim().isEmpty ? 'Phone is required' : null,
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _address,
              maxLines: 2,
              decoration: const InputDecoration(labelText: 'Address'),
              validator: (v) =>
                  v == null || v.trim().isEmpty ? 'Address is required' : null,
            ),
            const SizedBox(height: 12),
            DropdownButtonFormField(
              initialValue: _role,
              decoration: const InputDecoration(labelText: 'I am a'),
              items: const [
                DropdownMenuItem(value: 'customer', child: Text('Customer')),
                DropdownMenuItem(
                  value: 'kitchen_owner',
                  child: Text('Kitchen Owner'),
                ),
                DropdownMenuItem(value: 'rider', child: Text('Delivery Rider')),
              ],
              onChanged: (v) => setState(() => _role = v!),
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _email,
              keyboardType: TextInputType.emailAddress,
              decoration: const InputDecoration(labelText: 'Email'),
              validator: (v) =>
                  v == null || !v.contains('@') ? 'Enter a valid email' : null,
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _password,
              obscureText: true,
              decoration: const InputDecoration(
                labelText: 'Password (at least 6 characters)',
              ),
              validator: (v) => v == null || v.length < 6
                  ? 'Use at least 6 characters'
                  : null,
            ),
            const SizedBox(height: 24),
            FilledButton(
              onPressed: _loading ? null : _signup,
              child: Text(_loading ? 'Creating account...' : 'Create account'),
            ),
          ],
        ),
      ),
    ),
  );
}

class RoleRouter extends StatelessWidget {
  const RoleRouter({super.key});
  @override
  Widget build(BuildContext context) => FutureBuilder<Map<String, dynamic>>(
    future: Supabase.instance.client.from('profiles').select().single(),
    builder: (context, snapshot) {
      if (snapshot.hasError) {
        return SetupNeeded(error: snapshot.error.toString());
      }
      if (!snapshot.hasData) {
        return const Scaffold(body: Center(child: CircularProgressIndicator()));
      }
      final role = switch (snapshot.data!['role']) {
        'kitchen_owner' => UserRole.owner,
        'rider' => UserRole.rider,
        _ => UserRole.customer,
      };
      return HomeScreen(role: role);
    },
  );
}

class SetupNeeded extends StatelessWidget {
  const SetupNeeded({required this.error, super.key});
  final String error;
  @override
  Widget build(BuildContext context) => Scaffold(
    body: Center(
      child: Padding(
        padding: const EdgeInsets.all(24),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            const Icon(Icons.construction, size: 72),
            const SizedBox(height: 16),
            const Text(
              'Database setup is needed',
              style: TextStyle(fontSize: 21, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 8),
            const Text(
              'Run the supplied schema.sql in Supabase SQL Editor, then sign in again.',
              textAlign: TextAlign.center,
            ),
            TextButton(
              onPressed: () => Supabase.instance.client.auth.signOut(),
              child: const Text('Sign out'),
            ),
          ],
        ),
      ),
    ),
  );
}

enum UserRole { customer, owner, rider }

class HomeScreen extends StatefulWidget {
  const HomeScreen({required this.role, super.key});
  final UserRole role;
  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  int index = 0;
  @override
  Widget build(BuildContext context) {
    final pages = switch (widget.role) {
      UserRole.customer => const [CustomerPage(), OrdersPage(), ProfilePage()],
      UserRole.owner => const [KitchenPage(), OrdersPage(), ProfilePage()],
      UserRole.rider => const [DeliveriesPage(), EarningsPage(), ProfilePage()],
    };
    final labels = switch (widget.role) {
      UserRole.customer => const ['Discover', 'My Orders', 'Profile'],
      UserRole.owner => const ['My Kitchen', 'Orders', 'Profile'],
      UserRole.rider => const ['Deliveries', 'Earnings', 'Profile'],
    };
    return Scaffold(
      appBar: AppBar(title: Text(labels[index])),
      body: pages[index],
      bottomNavigationBar: NavigationBar(
        selectedIndex: index,
        onDestinationSelected: (v) => setState(() => index = v),
        destinations: [
          NavigationDestination(
            icon: Icon(
              widget.role == UserRole.rider
                  ? Icons.delivery_dining
                  : Icons.restaurant,
            ),
            label: labels[0],
          ),
          NavigationDestination(
            icon: const Icon(Icons.receipt_long),
            label: labels[1],
          ),
          NavigationDestination(
            icon: const Icon(Icons.person_outline),
            label: labels[2],
          ),
        ],
      ),
    );
  }
}

class CustomerPage extends StatelessWidget {
  const CustomerPage({super.key});
  @override
  Widget build(BuildContext context) => const _InfoPage(
    icon: Icons.restaurant,
    title: 'Nearby kitchens',
    message: 'Kitchen discovery will appear here.',
  );
}

class KitchenPage extends StatefulWidget {
  const KitchenPage({super.key});
  @override
  State<KitchenPage> createState() => _KitchenPageState();
}

class _KitchenPageState extends State<KitchenPage> {
  final _client = Supabase.instance.client;
  bool _loading = true;
  Map<String, dynamic>? _kitchen;
  List<Map<String, dynamic>> _items = [];

  @override
  void initState() {
    super.initState();
    _load();
  }

  Future<void> _load() async {
    setState(() => _loading = true);
    try {
      final kitchen = await _client
          .from('kitchens')
          .select()
          .eq('owner_id', _client.auth.currentUser!.id)
          .maybeSingle();
      if (kitchen != null) {
        final items = await _client
            .from('menu_items')
            .select()
            .eq('kitchen_id', kitchen['id'])
            .order('created_at', ascending: false);
        _items = List<Map<String, dynamic>>.from(items);
      }
      _kitchen = kitchen;
    } on PostgrestException catch (e) {
      if (mounted) _message(e.message);
    } finally {
      if (mounted) setState(() => _loading = false);
    }
  }

  void _message(String text) =>
      ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(text)));

  Future<void> _createKitchen() async {
    final result = await showDialog<_KitchenDetails>(
      context: context,
      builder: (_) => const KitchenDialog(),
    );
    if (result == null) return;
    try {
      await _client.from('kitchens').insert({
        'owner_id': _client.auth.currentUser!.id,
        'name': result.name,
        'address': result.address,
      });
      await _load();
    } on PostgrestException catch (e) {
      _message(e.message);
    }
  }

  Future<void> _editItem([Map<String, dynamic>? item]) async {
    final result = await showDialog<_MenuDetails>(
      context: context,
      builder: (_) => MenuItemDialog(item: item),
    );
    if (result == null) return;
    final data = {
      'name': result.name,
      'description': result.description,
      'price': result.price,
      'is_available': result.available,
    };
    try {
      if (item == null) {
        await _client.from('menu_items').insert({
          ...data,
          'kitchen_id': _kitchen!['id'],
        });
      } else {
        await _client.from('menu_items').update(data).eq('id', item['id']);
      }
      await _load();
    } on PostgrestException catch (e) {
      _message(e.message);
    }
  }

  Future<void> _deleteItem(Map<String, dynamic> item) async {
    final yes = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Delete menu item?'),
        content: Text('Remove ${item['name']}?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, false),
            child: const Text('Cancel'),
          ),
          FilledButton(
            onPressed: () => Navigator.pop(context, true),
            child: const Text('Delete'),
          ),
        ],
      ),
    );
    if (yes != true) return;
    await _client.from('menu_items').delete().eq('id', item['id']);
    await _load();
  }

  @override
  Widget build(BuildContext context) {
    if (_loading) return const Center(child: CircularProgressIndicator());
    if (_kitchen == null) {
      return Center(
        child: Padding(
          padding: const EdgeInsets.all(28),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              const Icon(Icons.storefront, size: 72),
              const SizedBox(height: 14),
              const Text(
                'Create your kitchen first',
                style: TextStyle(fontSize: 21, fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 8),
              const Text('Your menu will be connected to this kitchen.'),
              const SizedBox(height: 18),
              FilledButton.icon(
                onPressed: _createKitchen,
                icon: const Icon(Icons.add),
                label: const Text('Create kitchen'),
              ),
            ],
          ),
        ),
      );
    }
    return RefreshIndicator(
      onRefresh: _load,
      child: ListView(
        padding: const EdgeInsets.all(16),
        children: [
          Text(
            _kitchen!['name'],
            style: Theme.of(context).textTheme.headlineSmall,
          ),
          Text(_kitchen!['address']),
          const SizedBox(height: 18),
          Row(
            children: [
              Text('Menu items', style: Theme.of(context).textTheme.titleLarge),
              const Spacer(),
              FilledButton.icon(
                onPressed: () => _editItem(),
                icon: const Icon(Icons.add),
                label: const Text('Add item'),
              ),
            ],
          ),
          const SizedBox(height: 8),
          if (_items.isEmpty)
            const Padding(
              padding: EdgeInsets.all(28),
              child: Center(child: Text('No menu item yet.')),
            ),
          for (final item in _items)
            Card(
              child: ListTile(
                title: Text(item['name']),
                subtitle: Text(
                  '${item['description'] ?? ''}\n৳${item['price']} ${item['is_available'] ? '• Available' : '• Unavailable'}',
                ),
                isThreeLine: true,
                trailing: PopupMenuButton<String>(
                  onSelected: (v) =>
                      v == 'edit' ? _editItem(item) : _deleteItem(item),
                  itemBuilder: (_) => const [
                    PopupMenuItem(value: 'edit', child: Text('Edit')),
                    PopupMenuItem(value: 'delete', child: Text('Delete')),
                  ],
                ),
              ),
            ),
        ],
      ),
    );
  }
}

class _KitchenDetails {
  const _KitchenDetails(this.name, this.address);
  final String name, address;
}

class KitchenDialog extends StatefulWidget {
  const KitchenDialog({super.key});
  @override
  State<KitchenDialog> createState() => _KitchenDialogState();
}

class _KitchenDialogState extends State<KitchenDialog> {
  final name = TextEditingController();
  final address = TextEditingController();
  @override
  Widget build(BuildContext context) => AlertDialog(
    title: const Text('Create kitchen'),
    content: Column(
      mainAxisSize: MainAxisSize.min,
      children: [
        TextField(
          controller: name,
          decoration: const InputDecoration(labelText: 'Kitchen name'),
        ),
        TextField(
          controller: address,
          decoration: const InputDecoration(labelText: 'Address'),
        ),
      ],
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: () {
          if (name.text.trim().isNotEmpty && address.text.trim().isNotEmpty) {
            Navigator.pop(
              context,
              _KitchenDetails(name.text.trim(), address.text.trim()),
            );
          }
        },
        child: const Text('Save'),
      ),
    ],
  );
}

class _MenuDetails {
  const _MenuDetails(this.name, this.description, this.price, this.available);
  final String name, description;
  final double price;
  final bool available;
}

class MenuItemDialog extends StatefulWidget {
  const MenuItemDialog({this.item, super.key});
  final Map<String, dynamic>? item;
  @override
  State<MenuItemDialog> createState() => _MenuItemDialogState();
}

class _MenuItemDialogState extends State<MenuItemDialog> {
  late final TextEditingController name;
  late final TextEditingController description;
  late final TextEditingController price;
  late bool available;
  @override
  void initState() {
    super.initState();
    name = TextEditingController(text: widget.item?['name'] ?? '');
    description = TextEditingController(
      text: widget.item?['description'] ?? '',
    );
    price = TextEditingController(
      text: widget.item?['price']?.toString() ?? '',
    );
    available = widget.item?['is_available'] ?? true;
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(widget.item == null ? 'Add menu item' : 'Edit menu item'),
    content: SingleChildScrollView(
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          TextField(
            controller: name,
            decoration: const InputDecoration(labelText: 'Name'),
          ),
          TextField(
            controller: description,
            decoration: const InputDecoration(labelText: 'Description'),
          ),
          TextField(
            controller: price,
            keyboardType: const TextInputType.numberWithOptions(decimal: true),
            decoration: const InputDecoration(labelText: 'Price (৳)'),
          ),
          SwitchListTile(
            contentPadding: EdgeInsets.zero,
            title: const Text('Available'),
            value: available,
            onChanged: (v) => setState(() => available = v),
          ),
        ],
      ),
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: () {
          final value = double.tryParse(price.text);
          if (name.text.trim().isNotEmpty && value != null && value > 0) {
            Navigator.pop(
              context,
              _MenuDetails(
                name.text.trim(),
                description.text.trim(),
                value,
                available,
              ),
            );
          }
        },
        child: const Text('Save'),
      ),
    ],
  );
}

class OrdersPage extends StatelessWidget {
  const OrdersPage({super.key});
  @override
  Widget build(BuildContext context) => const _InfoPage(
    icon: Icons.receipt_long,
    title: 'No orders yet',
    message: 'Your live orders will appear here.',
  );
}

class DeliveriesPage extends StatelessWidget {
  const DeliveriesPage({super.key});
  @override
  Widget build(BuildContext context) => const _InfoPage(
    icon: Icons.delivery_dining,
    title: 'Available deliveries',
    message: 'Ready orders will appear here for you to accept.',
  );
}

class EarningsPage extends StatelessWidget {
  const EarningsPage({super.key});
  @override
  Widget build(BuildContext context) => const _InfoPage(
    icon: Icons.account_balance_wallet,
    title: '৳0.00',
    message: 'Your completed delivery earnings will appear here.',
  );
}

class ProfilePage extends StatelessWidget {
  const ProfilePage({super.key});
  @override
  Widget build(BuildContext context) => Center(
    child: FilledButton.tonalIcon(
      onPressed: () => Supabase.instance.client.auth.signOut(),
      icon: const Icon(Icons.logout),
      label: const Text('Sign out'),
    ),
  );
}

class _InfoPage extends StatelessWidget {
  const _InfoPage({
    required this.icon,
    required this.title,
    required this.message,
  });
  final IconData icon;
  final String title, message;
  @override
  Widget build(BuildContext context) => Center(
    child: Padding(
      padding: const EdgeInsets.all(32),
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Icon(icon, size: 72, color: Theme.of(context).colorScheme.primary),
          const SizedBox(height: 16),
          Text(title, style: Theme.of(context).textTheme.headlineSmall),
          const SizedBox(height: 8),
          Text(message, textAlign: TextAlign.center),
        ],
      ),
    ),
  );
}
